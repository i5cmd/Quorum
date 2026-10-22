using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Quorum.Migrations
{
    /// <inheritdoc />
    public partial class ImgLink : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImgLink",
                table: "projekty",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImgLink",
                table: "projekty");
        }
    }
}
