using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace TaskManagement.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        [StringLength(255, ErrorMessage = "The FirstName should have a maximum of 255 characters.")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(255, ErrorMessage = "The LastName should have a maximum of 255 characters.")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [ValidateNever]
        public ICollection<UserTask> UserTasks { get; set; }

        public string FullName
        {
            get
            {
                return $"{LastName}, {FirstName}";
            }
        }
    }
}
