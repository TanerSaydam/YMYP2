using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Server.WebApi.Migrations
{
    /// <inheritdoc />
    public partial class mg2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: new Guid("35abdada-bfa6-43ea-b0cd-e633f0a9034c"));

            migrationBuilder.DeleteData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: new Guid("57247f2d-0f2f-4345-9036-7b7b3ad159d5"));

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: new Guid("7ee9fa3a-a766-4946-8733-feb744c631c2"));

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: new Guid("9a5a4b2f-6ab1-4bc4-8c43-7f91ee53e470"));

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: new Guid("efcf0a87-6c65-4c5c-8653-ac4449f5fb4c"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("56ca28fa-9edc-464e-bd49-2e5015183bf2"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("5c22a5bf-e94e-4ba7-aa82-b31df29fa3bd"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("abd7b816-52df-4949-833a-786710a1d234"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("db859682-65c5-4ca9-ac19-ae926fa1c12d"));

            migrationBuilder.CreateTable(
                name: "SocialMedias",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Icon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Link = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SocialMedias", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Experiences",
                columns: new[] { "Id", "Date", "Description", "Title", "Year" },
                values: new object[,]
                {
                    { new Guid("00741cc3-67a4-4804-91a9-7e1da5f3ba30"), "09.2011 - 08.2013", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed efficitur ex sit amet massa scelerisque scelerisque. Aliquam erat volutpat. Aenean interdum finibus efficitur. Praesent dapibus dolor felis, eu ultrices elit molestie.", "Visual Art &amp; Design", "2 Years" },
                    { new Guid("e5113491-17c7-4d2c-aa95-9d940299a4d4"), "09.2011 - 08.2013", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed efficitur ex sit amet massa scelerisque scelerisque. Aliquam erat volutpat. Aenean interdum finibus efficitur. Praesent dapibus dolor felis, eu ultrices elit molestie.", "Visual Art &amp; Design", "2 Years" }
                });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "CoverImageUrl", "Name" },
                values: new object[,]
                {
                    { new Guid("19a282b1-5a7a-497a-8bbd-234335d9ae74"), "project2.png", "e-Finans Projesi" },
                    { new Guid("2d0aec68-6981-4b2c-9069-3d746e2bf179"), "project1.png", "e-Muhasebe Projesi" },
                    { new Guid("7688ef98-0e15-4f21-89c0-539b83cd84e7"), "project3.png", "My Portfolio Projesi" }
                });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Image", "ImageUrl", "Order" },
                values: new object[,]
                {
                    { new Guid("468c8775-6dbd-458f-9058-9605a2d94a81"), null, "https://upload.wikimedia.org/wikipedia/commons/thumb/e/ee/.NET_Core_Logo.svg/2048px-.NET_Core_Logo.svg.png", 1 },
                    { new Guid("afdd749f-8d43-4e36-94f4-09548a906daf"), null, "https://blog.ninja-squad.com/assets/images/angular_gradient.png", 2 },
                    { new Guid("c8dcba72-82f2-4d81-8689-0dd7dad2fd4f"), null, "https://upload.wikimedia.org/wikipedia/commons/e/ea/Docker_%28container_engine%29_logo_%28cropped%29.png", 4 },
                    { new Guid("e607f28a-abe3-47b5-8365-d3e0a4148b19"), null, "https://pluralsight2.imgix.net/paths/images/domain-driven-design-6d10f953a0.png", 3 }
                });

            migrationBuilder.InsertData(
                table: "SocialMedias",
                columns: new[] { "Id", "Icon", "Link", "Name" },
                values: new object[,]
                {
                    { new Guid("0b7f0e2d-00ed-44be-b46f-4c06c3a6b520"), "fa-brands fa-github fs-30", "https://github.com/TanerSaydam", "GitHub" },
                    { new Guid("ccb569b9-97a0-436c-884c-68fc6d352d1c"), "fa-brands fa-youtube fs-30", "https://studio.youtube.com/channel/UC6Pw9YDMHq3EeNhIF8FMemw", "Youtube" },
                    { new Guid("e8e7d4d9-2320-42c2-827b-46f568cf53e1"), "fa-brands fa-linkedin fs-30", "https://www.linkedin.com/in/taner-saydam-b26336222/", "LinkedIn" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SocialMedias");

            migrationBuilder.DeleteData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: new Guid("00741cc3-67a4-4804-91a9-7e1da5f3ba30"));

            migrationBuilder.DeleteData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: new Guid("e5113491-17c7-4d2c-aa95-9d940299a4d4"));

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: new Guid("19a282b1-5a7a-497a-8bbd-234335d9ae74"));

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: new Guid("2d0aec68-6981-4b2c-9069-3d746e2bf179"));

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: new Guid("7688ef98-0e15-4f21-89c0-539b83cd84e7"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("468c8775-6dbd-458f-9058-9605a2d94a81"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("afdd749f-8d43-4e36-94f4-09548a906daf"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("c8dcba72-82f2-4d81-8689-0dd7dad2fd4f"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("e607f28a-abe3-47b5-8365-d3e0a4148b19"));

            migrationBuilder.InsertData(
                table: "Experiences",
                columns: new[] { "Id", "Date", "Description", "Title", "Year" },
                values: new object[,]
                {
                    { new Guid("35abdada-bfa6-43ea-b0cd-e633f0a9034c"), "09.2011 - 08.2013", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed efficitur ex sit amet massa scelerisque scelerisque. Aliquam erat volutpat. Aenean interdum finibus efficitur. Praesent dapibus dolor felis, eu ultrices elit molestie.", "Visual Art &amp; Design", "2 Years" },
                    { new Guid("57247f2d-0f2f-4345-9036-7b7b3ad159d5"), "09.2011 - 08.2013", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed efficitur ex sit amet massa scelerisque scelerisque. Aliquam erat volutpat. Aenean interdum finibus efficitur. Praesent dapibus dolor felis, eu ultrices elit molestie.", "Visual Art &amp; Design", "2 Years" }
                });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "CoverImageUrl", "Name" },
                values: new object[,]
                {
                    { new Guid("7ee9fa3a-a766-4946-8733-feb744c631c2"), "project1.png", "e-Muhasebe Projesi" },
                    { new Guid("9a5a4b2f-6ab1-4bc4-8c43-7f91ee53e470"), "project3.png", "My Portfolio Projesi" },
                    { new Guid("efcf0a87-6c65-4c5c-8653-ac4449f5fb4c"), "project2.png", "e-Finans Projesi" }
                });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Image", "ImageUrl", "Order" },
                values: new object[,]
                {
                    { new Guid("56ca28fa-9edc-464e-bd49-2e5015183bf2"), null, "https://upload.wikimedia.org/wikipedia/commons/thumb/e/ee/.NET_Core_Logo.svg/2048px-.NET_Core_Logo.svg.png", 1 },
                    { new Guid("5c22a5bf-e94e-4ba7-aa82-b31df29fa3bd"), null, "https://blog.ninja-squad.com/assets/images/angular_gradient.png", 2 },
                    { new Guid("abd7b816-52df-4949-833a-786710a1d234"), null, "https://upload.wikimedia.org/wikipedia/commons/e/ea/Docker_%28container_engine%29_logo_%28cropped%29.png", 4 },
                    { new Guid("db859682-65c5-4ca9-ac19-ae926fa1c12d"), null, "https://pluralsight2.imgix.net/paths/images/domain-driven-design-6d10f953a0.png", 3 }
                });
        }
    }
}
