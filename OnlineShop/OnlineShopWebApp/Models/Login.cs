using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShopWebApp.Models
{
    public class Login
    {
        [Required(ErrorMessage ="Не указан логин")]
        [StringLength(25,MinimumLength =5, ErrorMessage ="Логин должен содержать от 5 до 25 знаков.")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Не указан пароль")]
        public string Password { get; set; }       
        public bool Remember { get; set; }
        public string ReturnUrl { get; set; }
    }
}
