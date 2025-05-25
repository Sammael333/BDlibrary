using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BDlibrary.Migrations
{
    /// <inheritdoc />
    public partial class FixBirthDateType1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(name: "YearPublished", table: "Books");

            migrationBuilder.AddColumn<int>(
                name: "YearPublished",
                table: "Books",
                nullable: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
