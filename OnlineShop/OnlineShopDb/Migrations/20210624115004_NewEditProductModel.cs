using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineShop.Db.Migrations
{
    public partial class NewEditProductModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("26eab4d1-7080-4238-90b2-b8234b7ec1a9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("49874016-6395-49ed-9357-2e5e6766ca5b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5eae7488-8eec-4650-8be4-44497eced24b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("631d5747-a4bd-45b1-a730-0147c83a0865"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8560b5fa-d3cb-4fc6-838c-374059e93de9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a1179f8d-fe7c-47e5-9fdd-d4574b530ad7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("beaa27d2-18d5-4585-8657-956e7a1c5266"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fc0fec93-31e3-413d-9ea6-d759157e47a5"));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Cost", "Description", "ImagePath1", "ImagePath2", "ImagePath3", "Name" },
                values: new object[,]
                {
                    { new Guid("abb3c6c1-4825-413a-888f-1311842fcd51"), 700m, "Эта медитация поможет избавиться от стресса.", "/imajes/стресс.jpg", null, null, "Избавление от стресса" },
                    { new Guid("df01b8c8-21db-4d4a-b7a0-735796f4f4da"), 500m, "Поменяет отношение к богатсву.", "/imajes/деньги.jpg", null, null, "Принятие изобилия" },
                    { new Guid("8770ce15-b0da-43d7-971b-08715b77b0fb"), 800m, "SPA для души.", "/imajes/изобилие.jpg", null, null, "Женская энергия" },
                    { new Guid("2883041b-d5db-4f3a-a405-b7d9dbe6bbb1"), 500m, "Эта медитация поможет вам притянуть в вашу жизнь заветные желания.", "/imajes/желания.jpg", null, null, "Притяжение желаний" },
                    { new Guid("4f4a383a-cc72-4d1b-8453-55f9a9264884"), 900m, "Поможет приобрести сторойное тело в согласии с душой", "/imajes/стройное.jpg", null, null, "Стройное тело" },
                    { new Guid("30e09439-2953-4c1a-b24a-c7ecaa168e31"), 1000m, "Восстановление силы рода, исцеление рродовых программ.", "/imajes/род.jpg", null, null, "Энергия рода" },
                    { new Guid("4faadb3a-6e00-41a2-8b10-1dacc3f5e2db"), 800m, "Новолуние  - отличное время для обновления энергетики и поиска путей развития", "/imajes/денежн круг.jpe", null, null, "Денежная медитация на новолуние" },
                    { new Guid("b87d159c-2d24-423e-9c46-36e19dc8c325"), 990m, "Позволит расширить денежную ёмкость", "/imajes/денежная емкость.jpg", null, null, "Расширение денежной емкости" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2883041b-d5db-4f3a-a405-b7d9dbe6bbb1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("30e09439-2953-4c1a-b24a-c7ecaa168e31"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4f4a383a-cc72-4d1b-8453-55f9a9264884"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4faadb3a-6e00-41a2-8b10-1dacc3f5e2db"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8770ce15-b0da-43d7-971b-08715b77b0fb"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("abb3c6c1-4825-413a-888f-1311842fcd51"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b87d159c-2d24-423e-9c46-36e19dc8c325"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("df01b8c8-21db-4d4a-b7a0-735796f4f4da"));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Cost", "Description", "ImagePath1", "ImagePath2", "ImagePath3", "Name" },
                values: new object[,]
                {
                    { new Guid("631d5747-a4bd-45b1-a730-0147c83a0865"), 700m, "Эта медитация поможет избавиться от стресса.", "/imajes/стресс.jpg", null, null, "Избавление от стресса" },
                    { new Guid("8560b5fa-d3cb-4fc6-838c-374059e93de9"), 500m, "Поменяет отношение к богатсву.", "/imajes/деньги.jpg", null, null, "Принятие изобилия" },
                    { new Guid("a1179f8d-fe7c-47e5-9fdd-d4574b530ad7"), 800m, "SPA для души.", "/imajes/изобилие.jpg", null, null, "Женская энергия" },
                    { new Guid("fc0fec93-31e3-413d-9ea6-d759157e47a5"), 500m, "Эта медитация поможет вам притянуть в вашу жизнь заветные желания.", "/imajes/желания.jpg", null, null, "Притяжение желаний" },
                    { new Guid("5eae7488-8eec-4650-8be4-44497eced24b"), 900m, "Поможет приобрести сторойное тело в согласии с душой", "/imajes/стройное.jpg", null, null, "Стройное тело" },
                    { new Guid("49874016-6395-49ed-9357-2e5e6766ca5b"), 1000m, "Восстановление силы рода, исцеление рродовых программ.", "/imajes/род.jpg", null, null, "Энергия рода" },
                    { new Guid("beaa27d2-18d5-4585-8657-956e7a1c5266"), 800m, "Новолуние  - отличное время для обновления энергетики и поиска путей развития", "/imajes/денежн круг.jpe", null, null, "Денежная медитация на новолуние" },
                    { new Guid("26eab4d1-7080-4238-90b2-b8234b7ec1a9"), 990m, "Позволит расширить денежную ёмкость", "/imajes/денежная емкость.jpg", null, null, "Расширение денежной емкости" }
                });
        }
    }
}
