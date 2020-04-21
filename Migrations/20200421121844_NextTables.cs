using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class NextTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DocumentHistories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DocumentId = table.Column<int>(nullable: true),
                    EventType = table.Column<int>(nullable: true),
                    EventMadeBy = table.Column<int>(nullable: true),
                    UserId = table.Column<int>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocumentHistories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DocumentHistories_Documents_DocumentId",
                        column: x => x.DocumentId,
                        principalTable: "Documents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DocumentHistories_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FileTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FileTypes = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FileTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GlobalCorrectionLogs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DocumentId = table.Column<int>(nullable: true),
                    UserId = table.Column<int>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    InitialDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GlobalCorrectionLogs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GlobalCorrectionLogs_Documents_DocumentId",
                        column: x => x.DocumentId,
                        principalTable: "Documents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Files",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DocumentId = table.Column<int>(nullable: true),
                    FileName = table.Column<string>(nullable: true),
                    UserId = table.Column<int>(nullable: true),
                    UploadedDate = table.Column<DateTime>(nullable: true),
                    FileTypeId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Files", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Files_Documents_DocumentId",
                        column: x => x.DocumentId,
                        principalTable: "Documents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Files_FileTypes_FileTypeId",
                        column: x => x.FileTypeId,
                        principalTable: "FileTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Files_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DocumentHistories_DocumentId",
                table: "DocumentHistories",
                column: "DocumentId");

            migrationBuilder.CreateIndex(
                name: "IX_DocumentHistories_UserId",
                table: "DocumentHistories",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Files_DocumentId",
                table: "Files",
                column: "DocumentId");

            migrationBuilder.CreateIndex(
                name: "IX_Files_FileTypeId",
                table: "Files",
                column: "FileTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Files_UserId",
                table: "Files",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_GlobalCorrectionLogs_DocumentId",
                table: "GlobalCorrectionLogs",
                column: "DocumentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DocumentHistories");

            migrationBuilder.DropTable(
                name: "Files");

            migrationBuilder.DropTable(
                name: "GlobalCorrectionLogs");

            migrationBuilder.DropTable(
                name: "FileTypes");
        }
    }
}
