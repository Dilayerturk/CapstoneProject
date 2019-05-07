using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace refactoradiyos_final.Models
{
    public class UserClass
    {
        [Required(ErrorMessage = "Enter username!")]
        [Display(Name = "Username:")]
        [StringLength(maximumLength: 7, MinimumLength = 3, ErrorMessage = "Username Length must between 7 &3")]
        public string Uname { get; set; }
        [Required(ErrorMessage = "Enter mail!")]
        [Display(Name = "Enter mail:")]
        public string Uemail { get; set; }
        [Required(ErrorMessage = "Enter pass!")]
        [Display(Name = "Enter pass:")]
        [DataType(DataType.Password)]
        public string Upwd { get; set; }
        [Required(ErrorMessage = "Enter gender!")]
        [Display(Name = "Enter gender:")]
        public string Gender { get; set; }
        [Required(ErrorMessage = "Enter image!")]
        [Display(Name = "Enter image:")]
        public string Uimg { get; set; }
    }
}