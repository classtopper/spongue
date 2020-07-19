using System.Threading.Tasks;
using Spongue.Module.SampleData.Areas.SampleData.ViewModels;

namespace Spongue.Module.SampleData.Services
{
    public interface ISampleDataService
    {
        Task ResetToSampleData(SampleDataOption model);
    }
}
