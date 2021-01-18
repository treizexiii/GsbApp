using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GsbApp.Migrations
{
    public partial class ModelCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "adress",
                table: "Commercials",
                newName: "Adress");

            migrationBuilder.CreateTable(
                name: "FlateRateCategory",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Amount = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FlateRateCategory", x => x.ID);
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
                name: "FlateRate",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CommercialID = table.Column<int>(type: "INTEGER", nullable: true),
                    Date = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Quantity = table.Column<int>(type: "INTEGER", nullable: false),
                    FlateRateCategoryID = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FlateRate", x => x.ID);
                    table.ForeignKey(
                        name: "FK_FlateRate_Commercials_CommercialID",
                        column: x => x.CommercialID,
                        principalTable: "Commercials",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FlateRate_FlateRateCategory_FlateRateCategoryID",
                        column: x => x.FlateRateCategoryID,
                        principalTable: "FlateRateCategory",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ExpenceReport",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CommercialID = table.Column<int>(type: "INTEGER", nullable: true),
                    FlateRateID = table.Column<int>(type: "INTEGER", nullable: true),
                    Document = table.Column<int>(type: "INTEGER", nullable: false),
                    AmountCheck = table.Column<decimal>(type: "TEXT", nullable: false),
                    CheckDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    StatusID = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExpenceReport", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ExpenceReport_Commercials_CommercialID",
                        column: x => x.CommercialID,
                        principalTable: "Commercials",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ExpenceReport_FlateRate_FlateRateID",
                        column: x => x.FlateRateID,
                        principalTable: "FlateRate",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ExpenceReport_Status_StatusID",
                        column: x => x.StatusID,
                        principalTable: "Status",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ExpenceReport_CommercialID",
                table: "ExpenceReport",
                column: "CommercialID");

            migrationBuilder.CreateIndex(
                name: "IX_ExpenceReport_FlateRateID",
                table: "ExpenceReport",
                column: "FlateRateID");

            migrationBuilder.CreateIndex(
                name: "IX_ExpenceReport_StatusID",
                table: "ExpenceReport",
                column: "StatusID");

            migrationBuilder.CreateIndex(
                name: "IX_FlateRate_CommercialID",
                table: "FlateRate",
                column: "CommercialID");

            migrationBuilder.CreateIndex(
                name: "IX_FlateRate_FlateRateCategoryID",
                table: "FlateRate",
                column: "FlateRateCategoryID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ExpenceReport");

            migrationBuilder.DropTable(
                name: "FlateRate");

            migrationBuilder.DropTable(
                name: "Status");

            migrationBuilder.DropTable(
                name: "FlateRateCategory");

            migrationBuilder.RenameColumn(
                name: "Adress",
                table: "Commercials",
                newName: "adress");
        }
    }
}
