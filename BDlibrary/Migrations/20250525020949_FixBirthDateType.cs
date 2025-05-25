using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BDlibrary.Migrations
{
    /// <inheritdoc />
    public partial class FixBirthDateType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "BirthDate",
                table: "Authors",
                nullable: false,
                oldClrType: typeof(DateTime));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
