using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace refactoradiyos_final.Models
{
    public class UserModel
    {
        [Required(ErrorMessage = "Kullanıcı adınızı giriniz")]
        [Display(Name = "Adı Soyadı:")]
        public string DoctorName { get; set; }
        [Required(ErrorMessage = "Mail adresinizi giriniz")]
        [Display(Name = "Email:")]
        [DataType(DataType.EmailAddress)]
        [RegularExpression(@"^[a-zA-Z0-9$@$!%*?&#^-_. +]+$", ErrorMessage = "Geçersiz mail adresi")]
        public string DoctorEmail { get; set; }
        [Required(ErrorMessage = "Şifrenizi giriniz")]
        [Display(Name = "Şifre:")]
        [StringLength(maximumLength: 32, MinimumLength = 6, ErrorMessage = "Şifre minimum 6 maksimum 32 karekterli olmalıdır.")]
        [DataType(DataType.Password)]
        public string Doctorpwd { get; set; }
        [Required(ErrorMessage = "Şifrenizi onaylamak için tekrar giriniz")]
        [Display(Name = "Şifre Tekrar:")]
        [DataType(DataType.Password)]
        public string Doctorepwd { get; set; }
        [Required(ErrorMessage = "Telefon numaranızı giriniz")]
        [Display(Name = "Telefon:")]
        [StringLength(maximumLength: 11, MinimumLength = 11, ErrorMessage = "Lütfen telefon numaranızı 05055692144 şeklinde yazın")]
        [RegularExpression(@"^\d{11}$", ErrorMessage = "Telefon numarası karakter içermez")]
        public string Phone { get; set; }

    }


}