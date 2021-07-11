using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineShop.Db.Migrations
{
    public partial class AddFirstData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Cost", "Description", "ImagePath", "Name" },
                values: new object[,]
                {
                    { new Guid("115aad9d-a847-4e73-a699-eea61f9904f7"), 700m, "Эта медитация поможет избавиться от стресса.", "/imajes/стресс.jpg", "Избавление от стресса" },
                    { new Guid("d246bdda-a0d2-406f-83e7-ac69d44c7634"), 500m, "Поменяет отношение к богатсву.", "/imajes/деньги.jpg", "Принятие изобилия" },
                    { new Guid("457110be-0fd7-4059-998f-93656983f226"), 800m, "SPA для души.", "/imajes/изобилие.jpg", "Женская энергия" },
                    { new Guid("3986ffa4-2bc3-4738-99a2-dba72e799827"), 500m, "Эта медитация поможет вам притянуть в вашу жизнь заветные желания.", "/imajes/желания.jpg", "Притяжение желаний" },
                    { new Guid("cb8d8ccc-0c50-4455-b59c-62d337533eed"), 900m, "Поможет приобрести сторойное тело в согласии с душой", "/imajes/стройное.jpg", "Стройное тело" },
                    { new Guid("51a45ef0-6e9c-4047-8ea5-13e0bd43d840"), 1000m, "Восстановление силы рода, исцеление рродовых программ.", "/imajes/род.jpg", "Энергия рода" },
                    { new Guid("e1758baa-fac4-48ed-b6f5-93e28cbace48"), 800m, "Новолуние  - отличное время для обновления энергетики и поиска путей развития", "/imajes/денежн круг.jpe", "Денежная медитация на новолуние" },
                    { new Guid("f242be5f-f87f-418f-ae4c-3f376026fb13"), 990m, "Позволит расширить денежную ёмкость", "/imajes/денежная емкость.jpg", "Расширение денежной емкости" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("115aad9d-a847-4e73-a699-eea61f9904f7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3986ffa4-2bc3-4738-99a2-dba72e799827"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("457110be-0fd7-4059-998f-93656983f226"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("51a45ef0-6e9c-4047-8ea5-13e0bd43d840"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cb8d8ccc-0c50-4455-b59c-62d337533eed"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d246bdda-a0d2-406f-83e7-ac69d44c7634"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e1758baa-fac4-48ed-b6f5-93e28cbace48"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f242be5f-f87f-418f-ae4c-3f376026fb13"));
        }
    }
}
