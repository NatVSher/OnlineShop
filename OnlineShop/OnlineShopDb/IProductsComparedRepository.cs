using OnlineShop.Db.Models;
using System;
using System.Collections.Generic;

namespace OnlineShop.Db
{
    public interface IProductsComparedRepository
    {
        void Add(Product product, string userId);
        void Clear(string userId);
        void Remove(Guid productId, string userId);
        List<Product> GetAll(string userId);
        void GiveProductsCompared(string userName, string unauthorizedUserId);
    }
}