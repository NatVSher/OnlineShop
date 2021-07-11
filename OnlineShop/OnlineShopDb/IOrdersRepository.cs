using OnlineShop.Db.Models;
using System;
using System.Collections.Generic;

namespace OnlineShop.Db
{
    public interface IOrdersRepository
    {
        void Add(Order order);
        void EditStatus(Guid orderId, OrderStatuses newStatus);
        List<Order> GetAll();
        Order TryGetById(Guid id);
        List<Order> TryGetByUserId(string userId);
    }
}
