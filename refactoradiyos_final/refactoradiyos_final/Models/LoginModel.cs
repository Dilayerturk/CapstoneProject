using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace refactoradiyos_final.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Mail adresinizi giriniz")]
        [Display(Name = "Email:")]
        [DataType(DataType.EmailAddress)]
        [RegularExpression(@"^[a-zA-Z0-9$@$!%*?&#^-_. +]+$", ErrorMessage = "Geçersiz mail adresi")]
        public string DoctorEmail { get; set; }

        [Display(Name = "Şifre:")]
        [StringLength(maximumLength: 32, MinimumLength = 6, ErrorMessage = "Şifre minimum 6 maksimum 32 karekterli olmalıdır.")]
        [DataType(DataType.Password)]
        public string Doctorpwd { get; set; }

       
    }
}