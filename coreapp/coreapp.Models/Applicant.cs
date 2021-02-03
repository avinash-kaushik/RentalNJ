using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace coreapp.Models
{
    public class Applicant
    {
        public int Id { get; set; }

        [DisplayName("First Name")]
        [StringLength(50)]
        [Required(ErrorMessage = "First Name is required.")]
        public string FirstName { get; set; }

        [DisplayName("Last Name")]
        [StringLength(50)]
        [Required(ErrorMessage = "Last Name is required.")]
        public string LastName { get; set; }

        [DisplayName("Email Address")]
        [Required(ErrorMessage = "Email Address is required.")]
        [StringLength(50)]
        public string EmailAddress { get; set; }

        [DataType(DataType.Password)]
        [DisplayName("Password")]
        [Required(ErrorMessage = "Password is required.")]
        [StringLength(50)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [DisplayName("Confirm Password")]
        [Required(ErrorMessage = "Confirm Password is required.")]
        [Compare("Password", ErrorMessage = "Password and Confirmation Password must match.")]
        [StringLength(50)]
        public string ConfirmPassword { get; set; }

        public string image { get; set; }
    }
}
