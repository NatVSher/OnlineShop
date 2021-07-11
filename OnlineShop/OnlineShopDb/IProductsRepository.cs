using OnlineShop.Db.Models;
using System;
using System.Collections.Generic;

namespace OnlineShop.Db
{
    public interface IProductsRepository
    {
        List<Product> GetAll();
        Product TryGetById(Guid id);
        void Add(Product product);
        void Remove(Guid id);
        void Edit(Product product);
        List<Product> SearchByName(string serchWord);
    }
}
