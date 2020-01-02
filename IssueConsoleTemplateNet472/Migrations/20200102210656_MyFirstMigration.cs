using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IssueConsoleTemplateNet472.Migrations
{
    public partial class MyFirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "IceCreams",
                columns: table => new
                {
                    IceCreamId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 512, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IceCreams", x => x.IceCreamId);
                });

            migrationBuilder.InsertData(
                table: "IceCreams",
                columns: new[] { "IceCreamId", "Name" },
                values: new object[] { 1, "Vanilla" });

            migrationBuilder.InsertData(
                table: "IceCreams",
                columns: new[] { "IceCreamId", "Name" },
                values: new object[] { 2, "Chocolate" });

            migrationBuilder.InsertData(
                table: "IceCreams",
                columns: new[] { "IceCreamId", "Name" },
                values: new object[] { 3, "Strawberry" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IceCreams");
        }
    }
}
