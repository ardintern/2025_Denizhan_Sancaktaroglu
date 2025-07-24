using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HanStore.MvsWebUI.Models
{
    public class Register
    {
        [DisplayName("Ad")]
        public string Name { get; set; }

        [DisplayName("Soyad")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Kullanıcı adı alanı boş geçilemez.")]
        [DisplayName("Kullanıcı Adı")]
        public string UserName { get; set; }

        [EmailAddress(ErrorMessage = "E-posta adresinizi düzgün giriniz.")]
        [Required(ErrorMessage = "E-posta alanı boş geçilemez.")]
        [DisplayName("E-posta")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Şifre alanı boş geçilemez.")]
        [DisplayName("Şifre")]
        public string Password { get; set; }

        [Compare("Password", ErrorMessage = "Şifreler aynı değil.")]
        [Required(ErrorMessage = "Şifre tekrar alanı boş geçilemez.")]
        [DisplayName("Şifre Tekrar")]
        public string RePassword { get; set; }
    }
}