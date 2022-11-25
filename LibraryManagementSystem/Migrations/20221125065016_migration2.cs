using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibraryManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class migration2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_book_details_shelf_details_Shelf_ID",
                table: "book_details");

            migrationBuilder.RenameColumn(
                name: "Shelf_ID",
                table: "book_details",
                newName: "shelf_id");

            migrationBuilder.RenameIndex(
                name: "IX_book_details_Shelf_ID",
                table: "book_details",
                newName: "IX_book_details_shelf_id");

            migrationBuilder.AddForeignKey(
                name: "FK_book_details_shelf_details_shelf_id",
                table: "book_details",
                column: "shelf_id",
                principalTable: "shelf_details",
                principalColumn: "shelf_id",
                onDelete: ReferentialAction.SetNull);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_book_details_shelf_details_shelf_id",
                table: "book_details");

            migrationBuilder.RenameColumn(
                name: "shelf_id",
                table: "book_details",
                newName: "Shelf_ID");

            migrationBuilder.RenameIndex(
                name: "IX_book_details_shelf_id",
                table: "book_details",
                newName: "IX_book_details_Shelf_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_book_details_shelf_details_Shelf_ID",
                table: "book_details",
                column: "Shelf_ID",
                principalTable: "shelf_details",
                principalColumn: "shelf_id",
                onDelete: ReferentialAction.SetNull);
        }
    }
}
