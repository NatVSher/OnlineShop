using OnlineShopWebApp.Models;
using System;
using System.Collections.Generic;

namespace OnlineShopWebApp
{
    public class ProductComparedViewModel
    {
        public Guid Id { get; set; }
        public string UserId { get; set; }
        public ProductViewModel ProductViewModel { get; set; }
    }
}