using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ePizzaHub.WebUI.Models
{
    public class UserModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "E-Mailinizi Giriniz.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Adınızı Giriniz")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Şifrenizi Giriniz.")]
        public string Password { get; set; }

        [Compare("Password", ErrorMessage = "Şifreler Eşleşmiyor")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Telefon Numaranızı Giriniz.")]
        public string PhoneNumber { get; set; }
    }
}
