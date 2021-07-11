using System;
using System.Collections.Generic;
using System.Linq;

namespace OnlineShopWebApp.Models
{
    public class OrderViewModel
    {
        public Guid Id { get; set; }
        public string UserId { get; set; }
        public string DateOrder { get; set; }
        public string TimeOrder { get; set; }        
        public OrderStatusesViewModel OrderStatus { get; set; }
        public ContactDetailsViewModel ContactData { get; set; }       
        public List<BasketItemViewModel> Items { get; set; }
        public decimal Cost
        {
            get
            {
                return Items?.Sum(x => x.Cost) ?? 0;
            }
        }
        public OrderViewModel()
        {
            DateOrder = DateTime.Now.ToShortDateString();
            TimeOrder = DateTime.Now.ToShortTimeString();
            OrderStatus = OrderStatusesViewModel.Generated;
        }        
    }
}
