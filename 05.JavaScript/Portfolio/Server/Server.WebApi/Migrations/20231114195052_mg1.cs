using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Server.WebApi.Migrations
{
    /// <inheritdoc />
    public partial class mg1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Experiences",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Year = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Experiences", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CoverImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Skills",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Order = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skills", x => x.Id);
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Experiences");

            migrationBuilder.DropTable(
                name: "Projects");

            migrationBuilder.DropTable(
                name: "Skills");
        }
    }
}
