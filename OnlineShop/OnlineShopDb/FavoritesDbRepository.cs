using Microsoft.EntityFrameworkCore;
using OnlineShop.Db.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OnlineShop.Db
{
    public class FavoritesDbRepository : IFavoritesRepository
    {
        private readonly DatabaseContext databaseContext;

        public FavoritesDbRepository(DatabaseContext databaseContext)
        {
            this.databaseContext = databaseContext;
        }

        public List<Product> GetAll(string userId)
        {
            return databaseContext.Favorites.Where(x => x.UserId == userId)
                                            .Include(x => x.Product)
                                            .ThenInclude(x =>x.Images)
                                            .Select(x => x.Product)
                                            .ToList();
        }

        public void Add(Product product, string userId)
        {
            var existingProduct = databaseContext.Favorites.FirstOrDefault(x => x.UserId == userId && x.Product.Id == product.Id);
            if (existingProduct == null)
            {
                databaseContext.Favorites.Add(new FavoriteProduct { Product = product, UserId = userId });
                databaseContext.SaveChanges();
            }
        }
        public void Remove(Guid productId, string userId)
        {
            var removingFavorite = databaseContext.Favorites.FirstOrDefault(u => u.UserId == userId && u.Product.Id == productId);
            databaseContext.Favorites.Remove(removingFavorite);
            databaseContext.SaveChanges();
        }
        public void Clear(string userId)
        {
            var userFavoriteProducts = databaseContext.Favorites.Where(u => u.UserId == userId).ToList();
            databaseContext.Favorites.RemoveRange(userFavoriteProducts);
            databaseContext.SaveChanges();
        }
        public void GiveFavorites(string userName, string unauthorizedUserId)
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
