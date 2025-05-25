using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BDlibrary.Migrations
{
    /// <inheritdoc />
    public partial class ChangeYearPublishedType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
    name: "YearPublished",
    table: "Books",
    nullable: false,
    oldClrType: typeof(DateTime));

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
