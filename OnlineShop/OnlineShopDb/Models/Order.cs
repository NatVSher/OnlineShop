using System;
using System.Collections.Generic;

namespace OnlineShop.Db.Models
{
    public class Order
    {
        public Guid Id { get; set; }
        public string UserId { get; set; }
        public string DateOrder { get; set; }
        public string TimeOrder { get; set; }
        public OrderStatuses OrderStatus { get; set; }
        public ContactDetails ContactData { get; set; }
        public List<BasketItem> Items { get; set; }        
        public Order()
        {            
            DateOrder = DateTime.Now.ToShortDateString();
            TimeOrder = DateTime.Now.ToShortTimeString();
            OrderStatus = OrderStatuses.Generated;           
        }
    }
}
