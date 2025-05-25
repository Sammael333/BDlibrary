using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BDlibrary.Migrations
{
    /// <inheritdoc />
    public partial class FixBirthDateType2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "BirthDate",
                table: "Authors",
                newName: "BirthYear");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "BirthYear",
                table: "Authors",
                newName: "BirthDate");
        }
    }
}
