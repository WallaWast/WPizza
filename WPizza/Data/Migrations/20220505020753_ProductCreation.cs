using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WPizza.Data.Migrations
{
    public partial class ProductCreation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImageUrl", "Name", "Price" },
                values: new object[,]
                {
                    { 1, 1, "Creamy white garlic sauce, mozzarella, and Freshslice cheddar.", "", "Cheese Pizza", 3m },
                    { 2, 3, "", "", "Water (500 ml)", 1.5m },
                    { 3, 4, "Delicious, rich and sweet filo pastry dessert with nuts.", "", "Baklava", 3.49m },
                    { 4, 3, "", "", "Coke", 2m },
                    { 5, 2, "Field greens, quinoa, feta cheese, dried cranberries, beet slaw, strawberries, carrots, balsamic vinaigrette.", "", "Market Salad", 12.7m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
