using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ePizzaHub.WebUI.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "E-Mailinizi Giriniz.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Şifrenizi Giriniz.")]
        public string Password { get; set; }
    }
}
