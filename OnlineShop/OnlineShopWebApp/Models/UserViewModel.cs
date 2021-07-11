using Microsoft.AspNetCore.Http;
using System;
using System.ComponentModel.DataAnnotations;

namespace OnlineShopWebApp.Models
{
    public class UserViewModel
    {
        public String Id { get; set; }
        [Required(ErrorMessage = "Не указан логин")]
        [EmailAddress(ErrorMessage = "Логин должен совпадать с email")]
        public string Name { get; set; }       
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        [RegularExpression(@"\d{11}$", ErrorMessage = "Формат телефона: 88888888888")]
        public string PhoneNumber { get; set; }
        public string ImagePath { get; set; }
        public IFormFile UploadedFile { get; set; }
    }
}
