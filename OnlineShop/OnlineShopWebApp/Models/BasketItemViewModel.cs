using System;
using OnlineShopWebApp.Models;

namespace OnlineShopWebApp
{
    public class BasketItemViewModel
    {
        public Guid Id { get; set; }
        public ProductViewModel Product { get; set; }
        public int Amount { get; set; }
        public decimal Cost
        {
            get 
            {
                return Product.Cost * Amount;
            }
        }
    }
}