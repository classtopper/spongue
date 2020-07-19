using System.ComponentModel.DataAnnotations;

namespace Spongue.Module.Contacts.Areas.Contacts.ViewModels
{
    public class ContactAreaForm
    {
        public long Id { get; set; }

        [Required(ErrorMessage = "The {0} field is required.")]
        public string Name { get; set; }
    }
}
