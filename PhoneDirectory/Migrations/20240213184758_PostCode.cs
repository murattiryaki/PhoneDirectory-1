using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PhoneDirectory.Migrations
{
    /// <inheritdoc />
    public partial class PostCode : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PostCode",
                table: "Directory",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PostCode",
                table: "Directory");
        }
    }
}
