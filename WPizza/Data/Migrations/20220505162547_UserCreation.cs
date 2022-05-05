using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WPizza.Data.Migrations
{
    public partial class UserCreation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "Name", "Phone" },
                values: new object[] { 1, "12345 Mains St.", "Wallace Torres", "+1 222-333-4444" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "Name", "Phone" },
                values: new object[] { 2, "12345 Mains St.", "Andreza Carvalho", "+1 222-333-5555" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
