using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClassyChess1.Models
{
    public class UserModel
    {
        public int UserID { get; set; }
        [Display(Name = "First Name")]
        [Required(ErrorMessage = "Requires a first name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Requires a first name")]
        public string LastName { get; set; }
        [DataType(DataType.Password)]
        [StringLength(100, MinimumLength = 10, ErrorMessage = "Password needs to be at least 10 characters in length.")]
        public string Password { get; set; }
        [DataType(DataType.Password)]
        [System.ComponentModel.DataAnnotations.Compare("Password", ErrorMessage = "Passwords must match.")]
        [Display(Name = "Confirm Password")]
        public string ConfirmPassword { get; set; }
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Requires an email.")]
        //[Remote("EmailExist", "Email", AdditionalFields = "Id",
        //        ErrorMessage = "Email already registered")]
        public string Email { get; set; }
        public int UserType { get; set; } = 1;
        [Display(Name = "Want to be part of our Newsletter?")]
        public bool Newsletter { get; set; } = false;
    }
}