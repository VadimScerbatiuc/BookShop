using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Books.Migrations
{
    /// <inheritdoc />
    public partial class add_Fname_to_Test : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_test",
                table: "test");

            migrationBuilder.RenameTable(
                name: "test",
                newName: "Test");

            migrationBuilder.AddColumn<string>(
                name: "Fname",
                table: "Test",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Test",
                table: "Test",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Test",
                table: "Test");

            migrationBuilder.DropColumn(
                name: "Fname",
                table: "Test");

            migrationBuilder.RenameTable(
                name: "Test",
                newName: "test");

            migrationBuilder.AddPrimaryKey(
                name: "PK_test",
                table: "test",
                column: "Id");
        }
    }
}
