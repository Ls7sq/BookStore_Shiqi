using Microsoft.EntityFrameworkCore.Migrations;

namespace BookStore.Migrations
{
    public partial class AddInitialTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Desc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UnitPrice = table.Column<double>(type: "float", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Desc", "Image", "Name", "UnitPrice" },
                values: new object[] { 1, "CAD Designers use technology to help generate designs for complex projects.", "1.png", "Design CAD", 89.0 });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Desc", "Image", "Name", "UnitPrice" },
                values: new object[] { 2, "Designers xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx.", "1.png", "Design", 77.0 });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Desc", "Image", "Name", "UnitPrice" },
                values: new object[] { 3, "Designers xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx.", "1.png", "Design", 66.0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");
        }
    }
}
