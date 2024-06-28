using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeadsManagement.Infrastructure.Migrations
{
    public partial class InitialModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 80, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", maxLength: 400, nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    CategoryId = table.Column<int>(type: "INTEGER", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    Suburb = table.Column<string>(type: "TEXT", maxLength: 80, nullable: true),
                    Phone = table.Column<string>(type: "TEXT", maxLength: 9, nullable: true),
                    Email = table.Column<string>(type: "TEXT", maxLength: 80, nullable: true),
                    Status = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Contacts_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Photographer" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "Attorney" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { 3, "Medic" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { 4, "Mechanic" });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "Id", "CategoryId", "CreatedDate", "Description", "Email", "Name", "Phone", "Price", "Status", "Suburb" },
                values: new object[] { 1, 1, new DateTime(2024, 2, 22, 5, 14, 24, 0, DateTimeKind.Local), "Neighborhood Friend", "fozemwet@nauri.ml", "Peter Parker", "890258422", 600m, 0, "Forest Hills" });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "Id", "CategoryId", "CreatedDate", "Description", "Email", "Name", "Phone", "Price", "Status", "Suburb" },
                values: new object[] { 2, 2, new DateTime(2021, 1, 22, 14, 14, 24, 0, DateTimeKind.Local), "Avocado at Law", "kuz@iwocir.tc", "Matt Murdock", "880649211", 200m, 0, "Hell's Kitchen" });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "Id", "CategoryId", "CreatedDate", "Description", "Email", "Name", "Phone", "Price", "Status", "Suburb" },
                values: new object[] { 3, 3, new DateTime(2024, 6, 22, 9, 14, 24, 0, DateTimeKind.Local), "The mightiest magician in the cosmos", "fozemwet@nauri.ml", "Stephen Strange", "133486432", 600m, 0, "Greenwich Village" });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "Id", "CategoryId", "CreatedDate", "Description", "Email", "Name", "Phone", "Price", "Status", "Suburb" },
                values: new object[] { 4, 4, new DateTime(2024, 2, 22, 15, 14, 24, 0, DateTimeKind.Local), "Genius, billionaire, playboy, philanthropist", "zohusnu@rog.so", "Tony Stark", "433786225", 700.32m, 0, "Midtown Manhattan" });

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_CategoryId",
                table: "Contacts",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
