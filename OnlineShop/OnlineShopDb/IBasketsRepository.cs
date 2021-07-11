using OnlineShop.Db.Models;
using System;
using System.Collections.Generic;

namespace OnlineShop.Db
{
    public interface IBasketsRepository
    {
        Basket TryGetByUserId(string userId);
        void Add(Product product, string userId);
        void Remove(Guid productId, string userId);
        void Clear(string userId);
        List<Basket> GetAll();
        void GiveBasket(string userName, string unsignedUserId);
    }
}
