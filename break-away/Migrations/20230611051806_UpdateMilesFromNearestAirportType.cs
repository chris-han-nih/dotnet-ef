using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace break_away.Migrations
{
    /// <inheritdoc />
    public partial class UpdateMilesFromNearestAirportType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "MilesFromNearestAirport",
                table: "Lodgings",
                type: "decimal(8,3)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(8,2)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "MilesFromNearestAirport",
                table: "Lodgings",
                type: "decimal(8,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(8,3)");
        }
    }
}
