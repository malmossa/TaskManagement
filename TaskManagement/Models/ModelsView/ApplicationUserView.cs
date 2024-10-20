using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TaskManagement.Models.ModelsView
{
    public class ApplicationUserView
    {
        [ValidateNever]
        public string Id { get; set; }

        [Required]
        [EmailAddress]
        [Remote(action: "IsEmailInUse", "ApplicationUsers")]
        public string Email {  get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "Password and confirmation do not match.")]
        public string ConfirmPassword { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        [NotMapped]
        public string Role {  get; set; }       
    }
}
