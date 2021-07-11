using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineShop.Db.Migrations
{
    public partial class ChangeFavoritesModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FavoritesProduct");

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

            migrationBuilder.AddColumn<Guid>(
                name: "ProductId",
                table: "Favorites",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Cost", "Description", "ImagePath", "Name" },
                values: new object[,]
                {
                    { new Guid("632c2d10-ac54-4e1f-b81d-d1ebd510b3d3"), 700m, "Эта медитация поможет избавиться от стресса.", "/imajes/стресс.jpg", "Избавление от стресса" },
                    { new Guid("200e549b-2e65-4203-bfc4-44aac16c7c22"), 500m, "Поменяет отношение к богатсву.", "/imajes/деньги.jpg", "Принятие изобилия" },
                    { new Guid("15cd4dec-2c82-426f-9a2e-cb88f3091dda"), 800m, "SPA для души.", "/imajes/изобилие.jpg", "Женская энергия" },
                    { new Guid("478d014f-6992-4bc0-ac79-f1ebe8ad8df7"), 500m, "Эта медитация поможет вам притянуть в вашу жизнь заветные желания.", "/imajes/желания.jpg", "Притяжение желаний" },
                    { new Guid("0a86dd56-fecd-4dec-9979-ccca89d8a149"), 900m, "Поможет приобрести сторойное тело в согласии с душой", "/imajes/стройное.jpg", "Стройное тело" },
                    { new Guid("a26bd74d-9e04-471e-858a-9da656e2dc34"), 1000m, "Восстановление силы рода, исцеление рродовых программ.", "/imajes/род.jpg", "Энергия рода" },
                    { new Guid("01a9c5a2-2d31-462b-94af-deb7e67d7263"), 800m, "Новолуние  - отличное время для обновления энергетики и поиска путей развития", "/imajes/денежн круг.jpe", "Денежная медитация на новолуние" },
                    { new Guid("55810a37-3e4d-4211-8b57-023dac3c51a0"), 990m, "Позволит расширить денежную ёмкость", "/imajes/денежная емкость.jpg", "Расширение денежной емкости" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Favorites_ProductId",
                table: "Favorites",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_Favorites_Products_ProductId",
                table: "Favorites",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Favorites_Products_ProductId",
                table: "Favorites");

            migrationBuilder.DropIndex(
                name: "IX_Favorites_ProductId",
                table: "Favorites");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("01a9c5a2-2d31-462b-94af-deb7e67d7263"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0a86dd56-fecd-4dec-9979-ccca89d8a149"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("15cd4dec-2c82-426f-9a2e-cb88f3091dda"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("200e549b-2e65-4203-bfc4-44aac16c7c22"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("478d014f-6992-4bc0-ac79-f1ebe8ad8df7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("55810a37-3e4d-4211-8b57-023dac3c51a0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("632c2d10-ac54-4e1f-b81d-d1ebd510b3d3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a26bd74d-9e04-471e-858a-9da656e2dc34"));

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "Favorites");

            migrationBuilder.CreateTable(
                name: "FavoritesProduct",
                columns: table => new
                {
                    FavoritesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ItemsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FavoritesProduct", x => new { x.FavoritesId, x.ItemsId });
                    table.ForeignKey(
                        name: "FK_FavoritesProduct_Favorites_FavoritesId",
                        column: x => x.FavoritesId,
                        principalTable: "Favorites",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FavoritesProduct_Products_ItemsId",
                        column: x => x.ItemsId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_FavoritesProduct_ItemsId",
                table: "FavoritesProduct",
                column: "ItemsId");
        }
    }
}
