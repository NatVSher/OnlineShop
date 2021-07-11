using System;
using System.Collections.Generic;
using System.Linq;

namespace OnlineShopWebApp
{
    public class BasketViewModel
    {
        public Guid Id { get; set; }
        public string UserId { get; set; }
        public List<BasketItemViewModel> Items { get; set; }
        public decimal Cost
        {
            get
            {
                return Items?.Sum(x => x.Cost) ?? 0;
            }
        }
        //количество товаров в корзине
        public int CountProducts
        {
            get
            {
                return Items?.Sum(x => x.Amount) ?? 0;
            }
        }
    }
}