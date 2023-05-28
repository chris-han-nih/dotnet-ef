using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace break_away.Migrations
{
    /// <inheritdoc />
    public partial class AddColumnPhotoToDestination : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Photo",
                table: "Destinations",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Photo",
                table: "Destinations");
        }
    }
}
