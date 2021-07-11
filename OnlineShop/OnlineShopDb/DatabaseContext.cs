using Microsoft.EntityFrameworkCore;
using OnlineShop.Db.Models;
using System;
using System.Collections.Generic;

namespace OnlineShop.Db
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Basket> Baskets { get; set; }        
        public DbSet<FavoriteProduct> Favorites { get; set; }
        public DbSet<ProductCompared> ProductsCompared { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<ContactDetails> ContactDetails { get; set; }
        public DbSet<ImageProduct> ImagesProducts { get; set; }
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
            Database.Migrate();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {            
            modelBuilder.Entity<ImageProduct>().HasOne(p => p.Product).WithMany(p => p.Images).HasForeignKey(p => p.ProductId).OnDelete(DeleteBehavior.Cascade);
           
            var product1Id = Guid.Parse("48cb64dd-493d-41a7-8930-06e520276939");
            var product2Id = Guid.Parse("a32c0b6a-ce06-4b81-91bb-44cd5468e720");
            var product3Id = Guid.Parse("5d89f875-9cf3-478d-9b63-4c4e9b56b83f");
            var image1 = new ImageProduct
            {
                Id = Guid.Parse("5b5c066b-2559-429d-73da-08d937e1453e"),
                ImagePath = "/images/products/2f0a503c-f8d7-4145-85cc-789a562b2ea3.jpg",
                ProductId = product1Id
            };

            var image2 = new ImageProduct
            {
                Id = Guid.Parse("87a2d550-f86c-466d-73db-08d937e1453e"),
                ImagePath = "/images/products/2f0a503c-f8d7-4145-85cc-789a562b2ea3.jpg",
                ProductId = product2Id
            };
            var image3 = new ImageProduct
            {
                Id = Guid.Parse("88317b23-4d0d-4417-b287-edba4858054c"),
                ImagePath = "/images/products/2f0a503c-f8d7-4145-85cc-789a562b2ea3.jpg",
                ProductId = product3Id
            };

            modelBuilder.Entity<ImageProduct>().HasData(image1, image2, image3);

            modelBuilder.Entity<Product>().HasData(new List<Product>()
            {
                new Product(product1Id, "Name1", 10, "Desc1"),
                new Product(product2Id, "Name2", 20, "Desc2"),
                new Product(product3Id, "Name3", 30, "Desc3")
            });
        }
    }
}
