using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace break_away.Migrations
{
    /// <inheritdoc />
    public partial class AddInternetSpecialClass : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "InternetSpecials",
                columns: table => new
                {
                    InternetSpecialId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nights = table.Column<int>(type: "int", nullable: false),
                    CostUSD = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    FromDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ToDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AccommodationId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InternetSpecials", x => x.InternetSpecialId);
                    table.ForeignKey(
                        name: "FK_InternetSpecials_Lodgings_AccommodationId",
                        column: x => x.AccommodationId,
                        principalTable: "Lodgings",
                        principalColumn: "LodgingId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_InternetSpecials_AccommodationId",
                table: "InternetSpecials",
                column: "AccommodationId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InternetSpecials");
        }
    }
}
