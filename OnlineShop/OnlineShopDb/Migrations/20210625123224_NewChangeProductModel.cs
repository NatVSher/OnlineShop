using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineShop.Db.Migrations
{
    public partial class NewChangeProductModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "ImagePath1",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ImagePath2",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ImagePath3",
                table: "Products");

            migrationBuilder.CreateTable(
                name: "ImageProduct",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImageProduct", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ImageProduct_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Cost", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("c4e53d9a-7f5c-4e09-a1c3-69eb0fe3ee5c"), 700m, "Эта медитация поможет избавиться от стресса.", "Избавление от стресса" },
                    { new Guid("5d89f875-9cf3-478d-9b63-4c4e9b56b83f"), 500m, "Поменяет отношение к богатсву.", "Принятие изобилия" },
                    { new Guid("a32c0b6a-ce06-4b81-91bb-44cd5468e720"), 800m, "SPA для души.", "Женская энергия" },
                    { new Guid("48cb64dd-493d-41a7-8930-06e520276939"), 500m, "Эта медитация поможет вам притянуть в вашу жизнь заветные желания.", "Притяжение желаний" },
                    { new Guid("86cb0bef-c98c-443b-b3cc-e9ca27204512"), 900m, "Поможет приобрести сторойное тело в согласии с душой", "Стройное тело" },
                    { new Guid("88317b23-4d0d-4417-b287-edba4858054c"), 1000m, "Восстановление силы рода, исцеление рродовых программ.", "Энергия рода" },
                    { new Guid("9a313feb-8227-45c4-9d20-bdbcedb0c2ae"), 800m, "Новолуние  - отличное время для обновления энергетики и поиска путей развития", "Денежная медитация на новолуние" },
                    { new Guid("1b1dd28d-da16-4936-96ed-5710e807d743"), 990m, "Позволит расширить денежную ёмкость", "Расширение денежной емкости" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ImageProduct_ProductId",
                table: "ImageProduct",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ImageProduct");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1b1dd28d-da16-4936-96ed-5710e807d743"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("48cb64dd-493d-41a7-8930-06e520276939"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5d89f875-9cf3-478d-9b63-4c4e9b56b83f"));

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
                keyValue: new Guid("a32c0b6a-ce06-4b81-91bb-44cd5468e720"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c4e53d9a-7f5c-4e09-a1c3-69eb0fe3ee5c"));

            migrationBuilder.AddColumn<string>(
                name: "ImagePath1",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImagePath2",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImagePath3",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

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
    }
}
