using Microsoft.EntityFrameworkCore;
using OnlineShop.Db.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OnlineShop.Db
{
    public class OrdersDbRepository : IOrdersRepository
    {
        private readonly DatabaseContext databaseContext;

        public OrdersDbRepository(DatabaseContext databaseContext)
        {
            this.databaseContext = databaseContext;
        }
        public void Add(Order order)
        {            
            databaseContext.ContactDetails.Add(order.ContactData);
            databaseContext.Orders.Add(order);
            databaseContext.SaveChanges();
        }
        public List<Order> GetAll()
        {
            return databaseContext.Orders
                .Include(x => x.ContactData)
                .Include(x => x.Items)
                .ThenInclude(x => x.Product)
                .ThenInclude(x => x.Images)
                .ToList();
        }
        public Order TryGetById(Guid id)
        {
            return databaseContext.Orders
                .Include(x => x.ContactData)
                .Include(x => x.Items)
                .ThenInclude(x => x.Product)
                .ThenInclude(x => x.Images)
                .FirstOrDefault(x => x.Id == id);
        }
        public List<Order> TryGetByUserId(string userId)
        {
            return databaseContext.Orders
                .Include(x => x.ContactData)
                .Include(x => x.Items)
                .ThenInclude(x => x.Product)
                .ThenInclude(x => x.Images)
                .Where(x => x.UserId == userId)
                .ToList();
        }
        public void EditStatus(Guid orderId, OrderStatuses newStatus)
        {
            var editOrder = TryGetById(orderId);
            if (editOrder != null)
                editOrder.OrderStatus = newStatus;
            databaseContext.SaveChanges();
        }
    }
}
