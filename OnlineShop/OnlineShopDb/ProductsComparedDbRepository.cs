using Microsoft.EntityFrameworkCore;
using OnlineShop.Db.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OnlineShop.Db
{
    public class ProductsComparedDbRepository : IProductsComparedRepository
    {
        private readonly DatabaseContext databaseContext;

        public ProductsComparedDbRepository(DatabaseContext databaseContext)
        {
            this.databaseContext = databaseContext;
        }

        public List<Product> GetAll(string userId)
        {
            return databaseContext.ProductsCompared.Where(x => x.UserId == userId)
                                            .Include(x => x.Product)
                                            .ThenInclude(x => x.Images)
                                            .Select(x => x.Product)
                                            .ToList();
        }

        public void Add(Product product, string userId)
        {
            var existingProduct = databaseContext.ProductsCompared.FirstOrDefault(x => x.UserId == userId && x.Product.Id == product.Id);
            if (existingProduct == null)
            {
                databaseContext.ProductsCompared.Add(new ProductCompared { Product = product, UserId = userId });
                databaseContext.SaveChanges();
            }
        }
        public void Remove(Guid productId, string userId)
        {
            var removingProductCompared = databaseContext.ProductsCompared.FirstOrDefault(x => x.UserId == userId && x.Product.Id == productId);
            databaseContext.ProductsCompared.Remove(removingProductCompared);
            databaseContext.SaveChanges();
        }
        public void Clear(string userId)
        {
            var userProductsCompared = databaseContext.ProductsCompared.Where(u => u.UserId == userId).ToList();
            databaseContext.ProductsCompared.RemoveRange(userProductsCompared);
            databaseContext.SaveChanges();
        }
        public void GiveProductsCompared(string userName, string unauthorizedUserId)
        {
            if (GetAll(unauthorizedUserId) != null)
            {
                var products = GetAll(unauthorizedUserId);
                foreach (var product in products)
                {
                    Add(product, userName);
                }
                Clear(unauthorizedUserId);
                databaseContext.SaveChanges();
            }
        }
    }
}
