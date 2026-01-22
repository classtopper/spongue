using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using Serilog;
using Spongue.Infrastructure;
using Spongue.Infrastructure.Data;
using Spongue.Module.Core.Extensions;
using Spongue.Module.Localization.Extensions;
using Spongue.Module.Localization.TagHelpers;
using Spongue.WebHost.Extensions;
using MediatR;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Microsoft.Extensions.WebEncoders;
using System.Text.Encodings.Web;
using System.Text.Unicode;
using Spongue.Module.Core.Data;
using Spongue.Infrastructure.Web;
using Spongue.Infrastructure.Modules;

var builder = WebApplication.CreateBuilder(args);

// -------------------- Configuration --------------------
// Add JSON, environment variables, etc.
var configuration = builder.Configuration;
var env = builder.Environment;

// -------------------- Serilog --------------------
Log.Logger = new LoggerConfiguration()
    .ReadFrom.Configuration(configuration)
    .CreateLogger();
builder.Host.UseSerilog();

// -------------------- Services --------------------

// EF Core with SQL Server (Docker)
builder.Services.AddDbContext<SpongueDbContext>(options =>
    options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

// Add modules (your modular architecture)
GlobalConfiguration.WebRootPath = env.WebRootPath;
GlobalConfiguration.ContentRootPath = env.ContentRootPath;
builder.Services.AddModules(env.ContentRootPath);

// Cookie policy
builder.Services.Configure<CookiePolicyOptions>(options =>
{
    options.CheckConsentNeeded = context => true;
    options.MinimumSameSitePolicy = SameSiteMode.None;
});

// Identity, HttpClient, Repository, etc.
builder.Services.AddCustomizedDataStore(configuration);
builder.Services.AddCustomizedIdentity(configuration);
builder.Services.AddHttpClient();
builder.Services.AddTransient(typeof(IRepository<>), typeof(Repository<>));
builder.Services.AddTransient(typeof(IRepositoryWithTypedId<,>), typeof(RepositoryWithTypedId<,>));
builder.Services.AddScoped<SlugRouteValueTransformer>();

builder.Services.AddCustomizedLocalization();

builder.Services.AddCustomizedMvc(GlobalConfiguration.Modules);
builder.Services.Configure<RazorViewEngineOptions>(options =>
{
    options.ViewLocationExpanders.Add(new ThemeableViewLocationExpander());
});
builder.Services.Configure<WebEncoderOptions>(options =>
{
    options.TextEncoderSettings = new TextEncoderSettings(UnicodeRanges.All);
});

builder.Services.AddScoped<ITagHelperComponent, LanguageDirectionTagHelperComponent>();
builder.Services.AddTransient<IRazorViewRenderer, RazorViewRenderer>();
builder.Services.AddAntiforgery(options => options.HeaderName = "X-XSRF-Token");
builder.Services.AddCloudscribePagination();

// Module initializers
foreach (var module in GlobalConfiguration.Modules)
{
    var moduleInitializerType = module.Assembly.GetTypes()
       .FirstOrDefault(t => typeof(IModuleInitializer).IsAssignableFrom(t));
    if (moduleInitializerType != null && moduleInitializerType != typeof(IModuleInitializer))
    {
        var moduleInitializer = (IModuleInitializer)Activator.CreateInstance(moduleInitializerType);
        builder.Services.AddSingleton(typeof(IModuleInitializer), moduleInitializer);
        moduleInitializer.ConfigureServices(builder.Services);
    }
}

// MediatR
builder.Services.AddMediatR(cfg =>
{
    cfg.RegisterServicesFromAssembly(typeof(Program).Assembly);
    cfg.RegisterServicesFromAssembly(typeof(Spongue.Module.Core.Extensions.SpongueSignInManager<>).Assembly);
});

// Swagger
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Spongue API", Version = "v1" });
});

// -------------------- Build --------------------
var app = builder.Build();

// -------------------- Middleware / Pipeline --------------------
if (env.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
else
{
    app.UseWhen(
        context => !context.Request.Path.StartsWithSegments("/api"),
        a => a.UseExceptionHandler("/Home/Error")
    );
    app.UseHsts();
}

app.UseWhen(
    context => !context.Request.Path.StartsWithSegments("/api"),
    a => a.UseStatusCodePagesWithReExecute("/Home/ErrorWithCode/{0}")
);

app.UseHttpsRedirection();
app.UseCustomizedStaticFiles(env);
app.UseRouting();
app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Spongue API V1");
});
app.UseCookiePolicy();
app.UseCustomizedIdentity();
app.UseCustomizedRequestLocalization();

app.UseEndpoints(endpoints =>
{
    endpoints.MapDynamicControllerRoute<SlugRouteValueTransformer>("/{**slug}");
    endpoints.MapControllerRoute(
        name: "areas",
        pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");
    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}");
});

// Initialize modules
var moduleInitializers = app.Services.GetServices<IModuleInitializer>();
foreach (var moduleInitializer in moduleInitializers)
{
    moduleInitializer.Configure(app, env);
}

// -------------------- Run --------------------
app.Run();
