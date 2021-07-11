using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OnlineShopWebApp.Models
{
    public class CreateProductViewModel
    {
        [Required(ErrorMessage = "Не указано название продукта")]
        [StringLength(60, ErrorMessage = "Название должно содержать не бльше 60 знаков.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Не указана цена")]
        [Range(1, 100000000, ErrorMessage = "Цена не может превышать 10000000 и быть меньше 1")]
        public decimal Cost { get; set; }

        [Required(ErrorMessage = "Не указано описание")]
        public string Description { get; set; }

        public IFormFile[] UploadedFiles { get; set; }        
    }
}
