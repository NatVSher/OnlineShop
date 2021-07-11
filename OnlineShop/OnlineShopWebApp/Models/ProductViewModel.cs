using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OnlineShopWebApp.Models
{
    public class ProductViewModel
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Не указано название продукта")]
        [StringLength(60, ErrorMessage = "Название должно содержать не бльше 60 знаков.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Не указана цена")]
        [Range(1, 100000000, ErrorMessage = "Цена не может превышать 10000000 и быть меньше 1")]
        public decimal Cost { get; set; }

        [Required(ErrorMessage = "Не указано описание")]
        public string Description { get; set; }

        public List<string> PathsToImages { get; set; } 

        public ProductViewModel()
        {
            PathsToImages = new List<string>();
        }    
    }
}
