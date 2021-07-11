using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineShop.Db.Migrations
{
    public partial class NewProductModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ImageProduct_Products_ProductId",
                table: "ImageProduct");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ImageProduct",
                table: "ImageProduct");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1b1dd28d-da16-4936-96ed-5710e807d743"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("86cb0bef-c98c-443b-b3cc-e9ca27204512"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("88317b23-4d0d-4417-b287-edba4858054c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9a313feb-8227-45c4-9d20-bdbcedb0c2ae"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c4e53d9a-7f5c-4e09-a1c3-69eb0fe3ee5c"));

            migrationBuilder.RenameTable(
                name: "ImageProduct",
                newName: "ImagesProducts");

            migrationBuilder.RenameIndex(
                name: "IX_ImageProduct_ProductId",
                table: "ImagesProducts",
                newName: "IX_ImagesProducts_ProductId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ImagesProducts",
                table: "ImagesProducts",
                column: "Id");

            migrationBuilder.InsertData(
                table: "ImagesProducts",
                columns: new[] { "Id", "ImagePath", "ProductId" },
                values: new object[,]
                {
                    { new Guid("5b5c066b-2559-429d-73da-08d937e1453e"), "/images/products/2f0a503c-f8d7-4145-85cc-789a562b2ea3.jpg", new Guid("48cb64dd-493d-41a7-8930-06e520276939") },
                    { new Guid("87a2d550-f86c-466d-73db-08d937e1453e"), "/images/products/2f0a503c-f8d7-4145-85cc-789a562b2ea3.jpg", new Guid("a32c0b6a-ce06-4b81-91bb-44cd5468e720") },
                    { new Guid("88317b23-4d0d-4417-b287-edba4858054c"), "/images/products/2f0a503c-f8d7-4145-85cc-789a562b2ea3.jpg", new Guid("5d89f875-9cf3-478d-9b63-4c4e9b56b83f") }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("48cb64dd-493d-41a7-8930-06e520276939"),
                columns: new[] { "Cost", "Description", "Name" },
                values: new object[] { 10m, "Desc1", "Name1" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5d89f875-9cf3-478d-9b63-4c4e9b56b83f"),
                columns: new[] { "Cost", "Description", "Name" },
                values: new object[] { 30m, "Desc3", "Name3" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a32c0b6a-ce06-4b81-91bb-44cd5468e720"),
                columns: new[] { "Cost", "Description", "Name" },
                values: new object[] { 20m, "Desc2", "Name2" });

            migrationBuilder.AddForeignKey(
                name: "FK_ImagesProducts_Products_ProductId",
                table: "ImagesProducts",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ImagesProducts_Products_ProductId",
                table: "ImagesProducts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ImagesProducts",
                table: "ImagesProducts");

            migrationBuilder.DeleteData(
                table: "ImagesProducts",
                keyColumn: "Id",
                keyValue: new Guid("5b5c066b-2559-429d-73da-08d937e1453e"));

            migrationBuilder.DeleteData(
                table: "ImagesProducts",
                keyColumn: "Id",
                keyValue: new Guid("87a2d550-f86c-466d-73db-08d937e1453e"));

            migrationBuilder.DeleteData(
                table: "ImagesProducts",
                keyColumn: "Id",
                keyValue: new Guid("88317b23-4d0d-4417-b287-edba4858054c"));

            migrationBuilder.RenameTable(
                name: "ImagesProducts",
                newName: "ImageProduct");

            migrationBuilder.RenameIndex(
                name: "IX_ImagesProducts_ProductId",
                table: "ImageProduct",
                newName: "IX_ImageProduct_ProductId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ImageProduct",
                table: "ImageProduct",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("48cb64dd-493d-41a7-8930-06e520276939"),
                columns: new[] { "Cost", "Description", "Name" },
                values: new object[] { 500m, "Эта медитация поможет вам притянуть в вашу жизнь заветные желания.", "Притяжение желаний" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5d89f875-9cf3-478d-9b63-4c4e9b56b83f"),
                columns: new[] { "Cost", "Description", "Name" },
                values: new object[] { 500m, "Поменяет отношение к богатсву.", "Принятие изобилия" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a32c0b6a-ce06-4b81-91bb-44cd5468e720"),
                columns: new[] { "Cost", "Description", "Name" },
                values: new object[] { 800m, "SPA для души.", "Женская энергия" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Cost", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("c4e53d9a-7f5c-4e09-a1c3-69eb0fe3ee5c"), 700m, "Эта медитация поможет избавиться от стресса.", "Избавление от стресса" },
                    { new Guid("86cb0bef-c98c-443b-b3cc-e9ca27204512"), 900m, "Поможет приобрести сторойное тело в согласии с душой", "Стройное тело" },
                    { new Guid("88317b23-4d0d-4417-b287-edba4858054c"), 1000m, "Восстановление силы рода, исцеление рродовых программ.", "Энергия рода" },
                    { new Guid("9a313feb-8227-45c4-9d20-bdbcedb0c2ae"), 800m, "Новолуние  - отличное время для обновления энергетики и поиска путей развития", "Денежная медитация на новолуние" },
                    { new Guid("1b1dd28d-da16-4936-96ed-5710e807d743"), 990m, "Позволит расширить денежную ёмкость", "Расширение денежной емкости" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_ImageProduct_Products_ProductId",
                table: "ImageProduct",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
