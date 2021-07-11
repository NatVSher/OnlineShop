using System;
using System.Collections.Generic;

namespace OnlineShop.Db.Models
{
    public class ProductCompared
    {
        public Guid Id { get; set; }
        public string UserId { get; set; }
        public Product Product { get; set; }        
    }
}