using System.Linq;
using System.Collections.Generic;
using OnlineShop.Db.Models;
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;

namespace OnlineShop.Db
{
    public class ProductsDbRepository : IProductsRepository
    {
        private readonly DatabaseContext databaseContext;       
        public ProductsDbRepository(DatabaseContext databaseContext)
        {
            this.databaseContext = databaseContext;            
        }

        public void Add(Product product)
        {
            databaseContext.Products.Add(product);
            databaseContext.SaveChanges();            
        }
        public void Edit(Product product)
        {
            var existingProduct = databaseContext.Products.Include(x => x.Images).FirstOrDefault(x => x.Id == product.Id);
            if (existingProduct == null)
                return;
            existingProduct.Name = product.Name;
            existingProduct.Cost = product.Cost;
            existingProduct.Description = product.Description;
            foreach (var image in product.Images)
            {
                image.ProductId = product.Id;
                databaseContext.ImagesProducts.Add(image);
            }
            databaseContext.SaveChanges();           
        }
        public List<Product> GetAll()
        {
            var products = databaseContext.Products.Include(x => x.Images).ToList();            
            return products;
        }
        public void Remove(Guid id)
        {
            databaseContext.Products.Remove(TryGetById(id));
            databaseContext.SaveChanges();            
        }
        public Product TryGetById(Guid id)
        {
            var product = databaseContext.Products.Include(x => x.Images).FirstOrDefault(product => product.Id == id);           
            return product;
        }
        public List<Product> SearchByName(string serchWord)
        {
            return databaseContext.Products.Where(product => product.Name.ToLower().Contains(serchWord.ToLower())).ToList();
        }
    }
}
