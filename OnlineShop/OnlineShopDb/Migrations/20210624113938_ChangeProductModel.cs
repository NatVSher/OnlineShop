using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineShop.Db.Migrations
{
    public partial class ChangeProductModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.RenameColumn(
                name: "ImagePath",
                table: "Products",
                newName: "ImagePath3");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "ImagePath1",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ImagePath2",
                table: "Products");

            migrationBuilder.RenameColumn(
                name: "ImagePath3",
                table: "Products",
                newName: "ImagePath");

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
        }
    }
}
