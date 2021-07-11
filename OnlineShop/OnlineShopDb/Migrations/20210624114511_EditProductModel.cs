using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineShop.Db.Migrations
{
    public partial class EditProductModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0ebc35c9-a26d-4fcd-b4a9-b4e42b0a48c1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("13da564b-4cd7-4c9b-83e8-b2246bbe81f7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("14ce00a4-d14e-4e9d-b472-0606abf156b9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("24ad7c35-a36e-4faf-8f08-8603f095b5b4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("58ed123a-c5f6-49b2-80cd-3be41338081a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("66b52ca2-8fb6-4de8-8333-4d5a1aaeffdf"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bcfdbdb0-a8c1-4a61-a53b-a97055ed45b8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e5bb73be-6a66-45b6-b40f-f478132c060c"));

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { new Guid("e5bb73be-6a66-45b6-b40f-f478132c060c"), 700m, "Эта медитация поможет избавиться от стресса.", "/imajes/стресс.jpg", null, null, "Избавление от стресса" },
                    { new Guid("13da564b-4cd7-4c9b-83e8-b2246bbe81f7"), 500m, "Поменяет отношение к богатсву.", "/imajes/деньги.jpg", null, null, "Принятие изобилия" },
                    { new Guid("24ad7c35-a36e-4faf-8f08-8603f095b5b4"), 800m, "SPA для души.", "/imajes/изобилие.jpg", null, null, "Женская энергия" },
                    { new Guid("bcfdbdb0-a8c1-4a61-a53b-a97055ed45b8"), 500m, "Эта медитация поможет вам притянуть в вашу жизнь заветные желания.", "/imajes/желания.jpg", null, null, "Притяжение желаний" },
                    { new Guid("0ebc35c9-a26d-4fcd-b4a9-b4e42b0a48c1"), 900m, "Поможет приобрести сторойное тело в согласии с душой", "/imajes/стройное.jpg", null, null, "Стройное тело" },
                    { new Guid("66b52ca2-8fb6-4de8-8333-4d5a1aaeffdf"), 1000m, "Восстановление силы рода, исцеление рродовых программ.", "/imajes/род.jpg", null, null, "Энергия рода" },
                    { new Guid("14ce00a4-d14e-4e9d-b472-0606abf156b9"), 800m, "Новолуние  - отличное время для обновления энергетики и поиска путей развития", "/imajes/денежн круг.jpe", null, null, "Денежная медитация на новолуние" },
                    { new Guid("58ed123a-c5f6-49b2-80cd-3be41338081a"), 990m, "Позволит расширить денежную ёмкость", "/imajes/денежная емкость.jpg", null, null, "Расширение денежной емкости" }
                });
        }
    }
}
