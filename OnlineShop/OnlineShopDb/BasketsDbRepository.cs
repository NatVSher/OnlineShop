using Microsoft.EntityFrameworkCore;
using OnlineShop.Db.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OnlineShop.Db
{
    public class BasketsDbRepository : IBasketsRepository
    {
        private readonly DatabaseContext databaseContext;

        public BasketsDbRepository(DatabaseContext databaseContext)
        {
            this.databaseContext = databaseContext;
        }

        public Basket TryGetByUserId(string userId)
        {
            return databaseContext.Baskets
                .Include(x => x.Items)
                .ThenInclude(x => x.Product)
                .ThenInclude(x => x.Images)
                .FirstOrDefault(x => x.UserId == userId);

        }

        public void Add(Product product, string userId)
        {
            var existingBasket = TryGetByUserId(userId);
            if (existingBasket == null)
            {
                var newBasket = new Basket
                {
                    UserId = userId
                };
                newBasket.Items = new List<BasketItem> 
                {
                    new BasketItem
                    {
                        Amount = 1,
                        Product = product                        
                    }
                };

                databaseContext.Baskets.Add(newBasket);
            }
            else
            {
                var existingBasketItem = existingBasket.Items.FirstOrDefault(x => x.Product.Id == product.Id);
                if (existingBasketItem != null)
                {
                    existingBasketItem.Amount += 1;
                }
                else
                {
                    existingBasket.Items.Add(new BasketItem
                    {
                        Amount = 1,
                        Product = product                       
                    });
                }
            }
            databaseContext.SaveChanges();
        }
        public void Remove(Guid productId, string userId)
        {
            var existingBasket = TryGetByUserId(userId);
            var existingBasketItem = existingBasket.Items.FirstOrDefault(x => x.Product.Id == productId);
            if (existingBasketItem.Amount > 1)
            {
                existingBasketItem.Amount -= 1;
            }
            else
            {
                existingBasket.Items.Remove(existingBasketItem);
            }
            databaseContext.SaveChanges();
        }
        public void Clear(string userId)
        {
            var existingBasket = TryGetByUserId(userId);
            databaseContext.Baskets.Remove(existingBasket);
            databaseContext.SaveChanges();
        }
        public List<Basket> GetAll()
        {
            return databaseContext.Baskets.ToList();
        }

        public void GiveBasket(string userName, string unauthorizedUserId)
        {
            var basketUnauthorizedUserId = TryGetByUserId(unauthorizedUserId);
            if (basketUnauthorizedUserId != null && basketUnauthorizedUserId.Items.Count!=0)
            {
                if (TryGetByUserId(userName) != null)
                {
                    Clear(userName);
                }
                basketUnauthorizedUserId.UserId = userName;
                
                databaseContext.SaveChanges();
            }
        }
    }
}
