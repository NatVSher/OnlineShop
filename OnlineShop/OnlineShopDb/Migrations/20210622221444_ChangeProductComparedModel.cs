using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineShop.Db.Migrations
{
    public partial class ChangeProductComparedModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BasketItems_Baskets_BasketId",
                table: "BasketItems");

            migrationBuilder.DropForeignKey(
                name: "FK_BasketItems_Orders_OrderId",
                table: "BasketItems");

            migrationBuilder.DropForeignKey(
                name: "FK_BasketItems_Products_ProductId",
                table: "BasketItems");

            migrationBuilder.DropTable(
                name: "ProductProductsCompared");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BasketItems",
                table: "BasketItems");

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

            migrationBuilder.RenameTable(
                name: "BasketItems",
                newName: "BasketItem");

            migrationBuilder.RenameIndex(
                name: "IX_BasketItems_ProductId",
                table: "BasketItem",
                newName: "IX_BasketItem_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_BasketItems_OrderId",
                table: "BasketItem",
                newName: "IX_BasketItem_OrderId");

            migrationBuilder.RenameIndex(
                name: "IX_BasketItems_BasketId",
                table: "BasketItem",
                newName: "IX_BasketItem_BasketId");

            migrationBuilder.AddColumn<Guid>(
                name: "ProductId",
                table: "ProductsCompared",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_BasketItem",
                table: "BasketItem",
                column: "Id");

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Cost", "Description", "ImagePath", "Name" },
                values: new object[,]
                {
                    { new Guid("fefe12b5-65c8-4b96-b409-dde86c0afa03"), 700m, "Эта медитация поможет избавиться от стресса.", "/imajes/стресс.jpg", "Избавление от стресса" },
                    { new Guid("a9fe1971-3908-4407-a8e9-8e246c57d947"), 500m, "Поменяет отношение к богатсву.", "/imajes/деньги.jpg", "Принятие изобилия" },
                    { new Guid("a17eccfa-4232-4758-8246-efa6c1af0fb9"), 800m, "SPA для души.", "/imajes/изобилие.jpg", "Женская энергия" },
                    { new Guid("98e54924-b9e0-41e6-a5cf-7e71e8a675c3"), 500m, "Эта медитация поможет вам притянуть в вашу жизнь заветные желания.", "/imajes/желания.jpg", "Притяжение желаний" },
                    { new Guid("f9b5a7c0-70ba-47d9-80ff-19d9a52092c6"), 900m, "Поможет приобрести сторойное тело в согласии с душой", "/imajes/стройное.jpg", "Стройное тело" },
                    { new Guid("606cf19d-942e-4f00-94b6-3f760e759119"), 1000m, "Восстановление силы рода, исцеление рродовых программ.", "/imajes/род.jpg", "Энергия рода" },
                    { new Guid("5b2b2f34-6f13-4ffb-b92e-a454ba48945f"), 800m, "Новолуние  - отличное время для обновления энергетики и поиска путей развития", "/imajes/денежн круг.jpe", "Денежная медитация на новолуние" },
                    { new Guid("3861b89b-d5c4-4970-baaf-b99241947a92"), 990m, "Позволит расширить денежную ёмкость", "/imajes/денежная емкость.jpg", "Расширение денежной емкости" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductsCompared_ProductId",
                table: "ProductsCompared",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_BasketItem_Baskets_BasketId",
                table: "BasketItem",
                column: "BasketId",
                principalTable: "Baskets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BasketItem_Orders_OrderId",
                table: "BasketItem",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BasketItem_Products_ProductId",
                table: "BasketItem",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductsCompared_Products_ProductId",
                table: "ProductsCompared",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BasketItem_Baskets_BasketId",
                table: "BasketItem");

            migrationBuilder.DropForeignKey(
                name: "FK_BasketItem_Orders_OrderId",
                table: "BasketItem");

            migrationBuilder.DropForeignKey(
                name: "FK_BasketItem_Products_ProductId",
                table: "BasketItem");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductsCompared_Products_ProductId",
                table: "ProductsCompared");

            migrationBuilder.DropIndex(
                name: "IX_ProductsCompared_ProductId",
                table: "ProductsCompared");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BasketItem",
                table: "BasketItem");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3861b89b-d5c4-4970-baaf-b99241947a92"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5b2b2f34-6f13-4ffb-b92e-a454ba48945f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("606cf19d-942e-4f00-94b6-3f760e759119"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("98e54924-b9e0-41e6-a5cf-7e71e8a675c3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a17eccfa-4232-4758-8246-efa6c1af0fb9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a9fe1971-3908-4407-a8e9-8e246c57d947"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f9b5a7c0-70ba-47d9-80ff-19d9a52092c6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fefe12b5-65c8-4b96-b409-dde86c0afa03"));

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "ProductsCompared");

            migrationBuilder.RenameTable(
                name: "BasketItem",
                newName: "BasketItems");

            migrationBuilder.RenameIndex(
                name: "IX_BasketItem_ProductId",
                table: "BasketItems",
                newName: "IX_BasketItems_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_BasketItem_OrderId",
                table: "BasketItems",
                newName: "IX_BasketItems_OrderId");

            migrationBuilder.RenameIndex(
                name: "IX_BasketItem_BasketId",
                table: "BasketItems",
                newName: "IX_BasketItems_BasketId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BasketItems",
                table: "BasketItems",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "ProductProductsCompared",
                columns: table => new
                {
                    ItemsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductsComparedId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductProductsCompared", x => new { x.ItemsId, x.ProductsComparedId });
                    table.ForeignKey(
                        name: "FK_ProductProductsCompared_Products_ItemsId",
                        column: x => x.ItemsId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductProductsCompared_ProductsCompared_ProductsComparedId",
                        column: x => x.ProductsComparedId,
                        principalTable: "ProductsCompared",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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
                name: "IX_ProductProductsCompared_ProductsComparedId",
                table: "ProductProductsCompared",
                column: "ProductsComparedId");

            migrationBuilder.AddForeignKey(
                name: "FK_BasketItems_Baskets_BasketId",
                table: "BasketItems",
                column: "BasketId",
                principalTable: "Baskets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BasketItems_Orders_OrderId",
                table: "BasketItems",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BasketItems_Products_ProductId",
                table: "BasketItems",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
