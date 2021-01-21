using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GsbApp.Migrations
{
    public partial class CreateModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Commercials",
                columns: table => new
                {
                    IdCommercial = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstName = table.Column<string>(type: "TEXT", nullable: true),
                    LastName = table.Column<string>(type: "TEXT", nullable: true),
                    Email = table.Column<string>(type: "TEXT", nullable: true),
                    Adress = table.Column<string>(type: "TEXT", nullable: true),
                    City = table.Column<string>(type: "TEXT", nullable: true),
                    CodePostal = table.Column<int>(type: "INTEGER", nullable: false),
                    HiringDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Password = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Commercials", x => x.IdCommercial);
                });

            migrationBuilder.CreateTable(
                name: "FlateRateCategory",
                columns: table => new
                {
                    IdFlateRateCategory = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Amount = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FlateRateCategory", x => x.IdFlateRateCategory);
                });

            migrationBuilder.CreateTable(
                name: "Status",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Status", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ExpenceReport",
                columns: table => new
                {
                    IdExpenceReport = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Date = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Document = table.Column<int>(type: "INTEGER", nullable: false),
                    AmountCheck = table.Column<decimal>(type: "TEXT", nullable: false),
                    CheckDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    IdStatus = table.Column<int>(type: "INTEGER", nullable: false),
                    StatusID = table.Column<int>(type: "INTEGER", nullable: true),
                    IdCommercial = table.Column<int>(type: "INTEGER", nullable: false),
                    CommercialIdCommercial = table.Column<int>(type: "INTEGER", nullable: true),
                    IdFlateRateCategory = table.Column<int>(type: "INTEGER", nullable: false),
                    FlateRateCategoryIdFlateRateCategory = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExpenceReport", x => x.IdExpenceReport);
                    table.ForeignKey(
                        name: "FK_ExpenceReport_Commercials_CommercialIdCommercial",
                        column: x => x.CommercialIdCommercial,
                        principalTable: "Commercials",
                        principalColumn: "IdCommercial",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ExpenceReport_FlateRateCategory_FlateRateCategoryIdFlateRateCategory",
                        column: x => x.FlateRateCategoryIdFlateRateCategory,
                        principalTable: "FlateRateCategory",
                        principalColumn: "IdFlateRateCategory",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ExpenceReport_Status_StatusID",
                        column: x => x.StatusID,
                        principalTable: "Status",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ExpenceReport_CommercialIdCommercial",
                table: "ExpenceReport",
                column: "CommercialIdCommercial");

            migrationBuilder.CreateIndex(
                name: "IX_ExpenceReport_FlateRateCategoryIdFlateRateCategory",
                table: "ExpenceReport",
                column: "FlateRateCategoryIdFlateRateCategory");

            migrationBuilder.CreateIndex(
                name: "IX_ExpenceReport_StatusID",
                table: "ExpenceReport",
                column: "StatusID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ExpenceReport");

            migrationBuilder.DropTable(
                name: "Commercials");

            migrationBuilder.DropTable(
                name: "FlateRateCategory");

            migrationBuilder.DropTable(
                name: "Status");
        }
    }
}
