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
    [Migration("20210624113938_ChangeProductModel")]
    partial class ChangeProductModel
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

                    b.ToTable("BasketItem");
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

                    b.Property<string>("ImagePath1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImagePath2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImagePath3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = new Guid("e5bb73be-6a66-45b6-b40f-f478132c060c"),
                            Cost = 700m,
                            Description = "Эта медитация поможет избавиться от стресса.",
                            ImagePath1 = "/imajes/стресс.jpg",
                            Name = "Избавление от стресса"
                        },
                        new
                        {
                            Id = new Guid("13da564b-4cd7-4c9b-83e8-b2246bbe81f7"),
                            Cost = 500m,
                            Description = "Поменяет отношение к богатсву.",
                            ImagePath1 = "/imajes/деньги.jpg",
                            Name = "Принятие изобилия"
                        },
                        new
                        {
                            Id = new Guid("24ad7c35-a36e-4faf-8f08-8603f095b5b4"),
                            Cost = 800m,
                            Description = "SPA для души.",
                            ImagePath1 = "/imajes/изобилие.jpg",
                            Name = "Женская энергия"
                        },
                        new
                        {
                            Id = new Guid("bcfdbdb0-a8c1-4a61-a53b-a97055ed45b8"),
                            Cost = 500m,
                            Description = "Эта медитация поможет вам притянуть в вашу жизнь заветные желания.",
                            ImagePath1 = "/imajes/желания.jpg",
                            Name = "Притяжение желаний"
                        },
                        new
                        {
                            Id = new Guid("0ebc35c9-a26d-4fcd-b4a9-b4e42b0a48c1"),
                            Cost = 900m,
                            Description = "Поможет приобрести сторойное тело в согласии с душой",
                            ImagePath1 = "/imajes/стройное.jpg",
                            Name = "Стройное тело"
                        },
                        new
                        {
                            Id = new Guid("66b52ca2-8fb6-4de8-8333-4d5a1aaeffdf"),
                            Cost = 1000m,
                            Description = "Восстановление силы рода, исцеление рродовых программ.",
                            ImagePath1 = "/imajes/род.jpg",
                            Name = "Энергия рода"
                        },
                        new
                        {
                            Id = new Guid("14ce00a4-d14e-4e9d-b472-0606abf156b9"),
                            Cost = 800m,
                            Description = "Новолуние  - отличное время для обновления энергетики и поиска путей развития",
                            ImagePath1 = "/imajes/денежн круг.jpe",
                            Name = "Денежная медитация на новолуние"
                        },
                        new
                        {
                            Id = new Guid("58ed123a-c5f6-49b2-80cd-3be41338081a"),
                            Cost = 990m,
                            Description = "Позволит расширить денежную ёмкость",
                            ImagePath1 = "/imajes/денежная емкость.jpg",
                            Name = "Расширение денежной емкости"
                        });
                });

            modelBuilder.Entity("OnlineShop.Db.Models.ProductCompared", b =>
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

                    b.ToTable("ProductsCompared");
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

            modelBuilder.Entity("OnlineShop.Db.Models.ProductCompared", b =>
                {
                    b.HasOne("OnlineShop.Db.Models.Product", "Product")
                        .WithMany("ProductsCompared")
                        .HasForeignKey("ProductId");

                    b.Navigation("Product");
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

                    b.Navigation("ProductsCompared");
                });
#pragma warning restore 612, 618
        }
    }
}
