using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace break_away.Migrations
{
    /// <inheritdoc />
    public partial class AddMilesFromNearestAirportColumnToLodging : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "MilesFromNearestAirport",
                table: "Lodgings",
                type: "decimal(8,2)",
                nullable: false,
                defaultValue: 0m);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MilesFromNearestAirport",
                table: "Lodgings");
        }
    }
}
