using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class AddDataDocument : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Documents",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Documents",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.InsertData(
                table: "Documents",
                columns: new[] { "id", "Customer_Name", "isFlagged" },
                values: new object[,]
                {
                    { 1001, "Chaman", true },
                    { 1002, "Sanjeev", true }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "Password", "Username" },
                values: new object[,]
                {
                    { 1, "chaman.raghav@vicesoftware.com", "123465487", "Chaman" },
                    { 2, "sanjeevsharma@vicesofteware.com", "12457845", "Sanjeev" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Documents",
                keyColumn: "id",
                keyValue: 1001);

            migrationBuilder.DeleteData(
                table: "Documents",
                keyColumn: "id",
                keyValue: 1002);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.InsertData(
                table: "Documents",
                columns: new[] { "id", "Customer_Name", "isFlagged" },
                values: new object[] { 1, "Chaman", true });

            migrationBuilder.InsertData(
                table: "Documents",
                columns: new[] { "id", "Customer_Name", "isFlagged" },
                values: new object[] { 2, "Sanjeev", true });
        }
    }
}
