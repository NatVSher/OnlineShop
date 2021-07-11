using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace OnlineShop.Db.Models
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public decimal Cost { get; set; }
        public string Description { get; set; }
        public List<ImageProduct> Images { get; set; }
        public List<BasketItem> BasketItem { get; set; }
        public List<FavoriteProduct> Favorites { get; set; }
        public List<ProductCompared> ProductsCompared { get; set; }

        public Product(Guid id, string name, decimal cost, string description) : this()
        {
            Id = id;
            Name = name;
            Cost = cost;
            Description = description;            
        }

        public Product()
        {
            BasketItem = new List<BasketItem>();
            Favorites = new List<FavoriteProduct>();
            ProductsCompared = new List<ProductCompared>();
            Images = new List<ImageProduct>();
        }
    }
}
