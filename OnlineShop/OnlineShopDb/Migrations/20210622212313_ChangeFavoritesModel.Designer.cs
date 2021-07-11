﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OnlineShop.Db;

namespace OnlineShop.Db.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20210622212313_ChangeFavoritesModel")]
    partial class ChangeFavoritesModel
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("OnlineShop.Db.Models.Basket", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Baskets");
                });

            modelBuilder.Entity("OnlineShop.Db.Models.BasketItem", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<Guid?>("BasketId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("OrderId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("BasketId");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("BasketItems");
                });

            modelBuilder.Entity("OnlineShop.Db.Models.ContactDetails", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ContactDetails");
                });

            modelBuilder.Entity("OnlineShop.Db.Models.FavoriteProduct", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("Favorites");
                });

            modelBuilder.Entity("OnlineShop.Db.Models.Order", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ContactDataId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DateOrder")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OrderStatus")
                        .HasColumnType("int");

                    b.Property<string>("TimeOrder")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ContactDataId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("OnlineShop.Db.Models.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("Cost")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = new Guid("632c2d10-ac54-4e1f-b81d-d1ebd510b3d3"),
                            Cost = 700m,
                            Description = "Эта медитация поможет избавиться от стресса.",
                            ImagePath = "/imajes/стресс.jpg",
                            Name = "Избавление от стресса"
                        },
                        new
                        {
                            Id = new Guid("200e549b-2e65-4203-bfc4-44aac16c7c22"),
                            Cost = 500m,
                            Description = "Поменяет отношение к богатсву.",
                            ImagePath = "/imajes/деньги.jpg",
                            Name = "Принятие изобилия"
                        },
                        new
                        {
                            Id = new Guid("15cd4dec-2c82-426f-9a2e-cb88f3091dda"),
                            Cost = 800m,
                            Description = "SPA для души.",
                            ImagePath = "/imajes/изобилие.jpg",
                            Name = "Женская энергия"
                        },
                        new
                        {
                            Id = new Guid("478d014f-6992-4bc0-ac79-f1ebe8ad8df7"),
                            Cost = 500m,
                            Description = "Эта медитация поможет вам притянуть в вашу жизнь заветные желания.",
                            ImagePath = "/imajes/желания.jpg",
                            Name = "Притяжение желаний"
                        },
                        new
                        {
                            Id = new Guid("0a86dd56-fecd-4dec-9979-ccca89d8a149"),
                            Cost = 900m,
                            Description = "Поможет приобрести сторойное тело в согласии с душой",
                            ImagePath = "/imajes/стройное.jpg",
                            Name = "Стройное тело"
                        },
                        new
                        {
                            Id = new Guid("a26bd74d-9e04-471e-858a-9da656e2dc34"),
                            Cost = 1000m,
                            Description = "Восстановление силы рода, исцеление рродовых программ.",
                            ImagePath = "/imajes/род.jpg",
                            Name = "Энергия рода"
                        },
                        new
                        {
                            Id = new Guid("01a9c5a2-2d31-462b-94af-deb7e67d7263"),
                            Cost = 800m,
                            Description = "Новолуние  - отличное время для обновления энергетики и поиска путей развития",
                            ImagePath = "/imajes/денежн круг.jpe",
                            Name = "Денежная медитация на новолуние"
                        },
                        new
                        {
                            Id = new Guid("55810a37-3e4d-4211-8b57-023dac3c51a0"),
                            Cost = 990m,
                            Description = "Позволит расширить денежную ёмкость",
                            ImagePath = "/imajes/денежная емкость.jpg",
                            Name = "Расширение денежной емкости"
                        });
                });

            modelBuilder.Entity("OnlineShop.Db.Models.ProductsCompared", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ProductsCompared");
                });

            modelBuilder.Entity("ProductProductsCompared", b =>
                {
                    b.Property<Guid>("ItemsId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ProductsComparedId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ItemsId", "ProductsComparedId");

                    b.HasIndex("ProductsComparedId");

                    b.ToTable("ProductProductsCompared");
                });

            modelBuilder.Entity("OnlineShop.Db.Models.BasketItem", b =>
                {
                    b.HasOne("OnlineShop.Db.Models.Basket", null)
                        .WithMany("Items")
                        .HasForeignKey("BasketId");

                    b.HasOne("OnlineShop.Db.Models.Order", null)
                        .WithMany("Items")
                        .HasForeignKey("OrderId");

                    b.HasOne("OnlineShop.Db.Models.Product", "Product")
                        .WithMany("BasketItem")
                        .HasForeignKey("ProductId");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("OnlineShop.Db.Models.FavoriteProduct", b =>
                {
                    b.HasOne("OnlineShop.Db.Models.Product", "Product")
                        .WithMany("Favorites")
                        .HasForeignKey("ProductId");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("OnlineShop.Db.Models.Order", b =>
                {
                    b.HasOne("OnlineShop.Db.Models.ContactDetails", "ContactData")
                        .WithMany()
                        .HasForeignKey("ContactDataId");

                    b.Navigation("ContactData");
                });

            modelBuilder.Entity("ProductProductsCompared", b =>
                {
                    b.HasOne("OnlineShop.Db.Models.Product", null)
                        .WithMany()
                        .HasForeignKey("ItemsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OnlineShop.Db.Models.ProductsCompared", null)
                        .WithMany()
                        .HasForeignKey("ProductsComparedId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("OnlineShop.Db.Models.Basket", b =>
                {
                    b.Navigation("Items");
                });

            modelBuilder.Entity("OnlineShop.Db.Models.Order", b =>
                {
                    b.Navigation("Items");
                });

            modelBuilder.Entity("OnlineShop.Db.Models.Product", b =>
                {
                    b.Navigation("BasketItem");

                    b.Navigation("Favorites");
                });
#pragma warning restore 612, 618
        }
    }
}
