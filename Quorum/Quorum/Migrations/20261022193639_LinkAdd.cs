using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Quorum.Migrations
{
    /// <inheritdoc />
    public partial class LinkAdd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Link",
                table: "projekty",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Link",
                table: "projekty");
        }
    }
}
