using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class SeedInitialData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "email", "password", "username" },
                values: new object[] { 1, "chaman.raghav@vicesoftware.com", "123465487", "Chaman" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "email", "password", "username" },
                values: new object[] { 2, "sanjeevsharma@vicesofteware.com", "12457845", "Sanjeev" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
