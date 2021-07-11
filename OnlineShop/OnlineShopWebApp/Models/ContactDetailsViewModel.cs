using System.ComponentModel.DataAnnotations;

namespace OnlineShopWebApp.Models
{
    public class ContactDetailsViewModel
    {
        [Required(ErrorMessage = "Не указано имя")]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "Имя должен содержать от 3 до 60 знаков.")]
        public string Name { get; set; }
        
        [Required(ErrorMessage = "Не указан адрес доставки")]
        [StringLength(60, MinimumLength = 5, ErrorMessage = "Адрес должен содержать от 10 до 80 знаков.")]
        public string Address { get; set; }
        
        [Required(ErrorMessage = "Не указан телефон")]
        [RegularExpression(@"\d{11}$", ErrorMessage ="Формат телефона: 88888888888")]
        public string Phone { get; set; }
        
        [Required(ErrorMessage = "Не указан email")]
        [EmailAddress(ErrorMessage ="Некорректный email")]
        public string Email { get; set; }
    }
}
