using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BDlibrary.Migrations
{
    /// <inheritdoc />
    public partial class correccion5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "YearOfBirth",
                table: "Authors",
                newName: "BirthDate");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "BirthDate",
                table: "Authors",
                newName: "YearOfBirth");
        }
    }
}
