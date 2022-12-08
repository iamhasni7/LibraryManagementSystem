using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibraryManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class mig3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_book_details_category_details_category_id",
                table: "book_details");

            migrationBuilder.DropForeignKey(
                name: "FK_book_details_shelf_details_shelf_id",
                table: "book_details");

            migrationBuilder.DropForeignKey(
                name: "FK_issued_details_book_details_book_id",
                table: "issued_details");

            migrationBuilder.DropForeignKey(
                name: "FK_issued_details_user_details_user_id",
                table: "issued_details");

            migrationBuilder.DropPrimaryKey(
                name: "PK_user_details",
                table: "user_details");

            migrationBuilder.DropPrimaryKey(
                name: "PK_shelf_details",
                table: "shelf_details");

            migrationBuilder.DropPrimaryKey(
                name: "PK_category_details",
                table: "category_details");

            migrationBuilder.DropPrimaryKey(
                name: "PK_book_details",
                table: "book_details");

            migrationBuilder.RenameTable(
                name: "user_details",
                newName: "user");

            migrationBuilder.RenameTable(
                name: "shelf_details",
                newName: "shelf");

            migrationBuilder.RenameTable(
                name: "category_details",
                newName: "category");

            migrationBuilder.RenameTable(
                name: "book_details",
                newName: "book");

            migrationBuilder.RenameIndex(
                name: "IX_book_details_shelf_id",
                table: "book",
                newName: "IX_book_shelf_id");

            migrationBuilder.RenameIndex(
                name: "IX_book_details_category_id",
                table: "book",
                newName: "IX_book_category_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_user",
                table: "user",
                column: "user_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_shelf",
                table: "shelf",
                column: "shelf_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_category",
                table: "category",
                column: "category_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_book",
                table: "book",
                column: "book_id");

            migrationBuilder.AddForeignKey(
                name: "FK_book_category_category_id",
                table: "book",
                column: "category_id",
                principalTable: "category",
                principalColumn: "category_id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_book_shelf_shelf_id",
                table: "book",
                column: "shelf_id",
                principalTable: "shelf",
                principalColumn: "shelf_id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_issued_details_book_book_id",
                table: "issued_details",
                column: "book_id",
                principalTable: "book",
                principalColumn: "book_id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_issued_details_user_user_id",
                table: "issued_details",
                column: "user_id",
                principalTable: "user",
                principalColumn: "user_id",
                onDelete: ReferentialAction.SetNull);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_book_category_category_id",
                table: "book");

            migrationBuilder.DropForeignKey(
                name: "FK_book_shelf_shelf_id",
                table: "book");

            migrationBuilder.DropForeignKey(
                name: "FK_issued_details_book_book_id",
                table: "issued_details");

            migrationBuilder.DropForeignKey(
                name: "FK_issued_details_user_user_id",
                table: "issued_details");

            migrationBuilder.DropPrimaryKey(
                name: "PK_user",
                table: "user");

            migrationBuilder.DropPrimaryKey(
                name: "PK_shelf",
                table: "shelf");

            migrationBuilder.DropPrimaryKey(
                name: "PK_category",
                table: "category");

            migrationBuilder.DropPrimaryKey(
                name: "PK_book",
                table: "book");

            migrationBuilder.RenameTable(
                name: "user",
                newName: "user_details");

            migrationBuilder.RenameTable(
                name: "shelf",
                newName: "shelf_details");

            migrationBuilder.RenameTable(
                name: "category",
                newName: "category_details");

            migrationBuilder.RenameTable(
                name: "book",
                newName: "book_details");

            migrationBuilder.RenameIndex(
                name: "IX_book_shelf_id",
                table: "book_details",
                newName: "IX_book_details_shelf_id");

            migrationBuilder.RenameIndex(
                name: "IX_book_category_id",
                table: "book_details",
                newName: "IX_book_details_category_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_user_details",
                table: "user_details",
                column: "user_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_shelf_details",
                table: "shelf_details",
                column: "shelf_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_category_details",
                table: "category_details",
                column: "category_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_book_details",
                table: "book_details",
                column: "book_id");

            migrationBuilder.AddForeignKey(
                name: "FK_book_details_category_details_category_id",
                table: "book_details",
                column: "category_id",
                principalTable: "category_details",
                principalColumn: "category_id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_book_details_shelf_details_shelf_id",
                table: "book_details",
                column: "shelf_id",
                principalTable: "shelf_details",
                principalColumn: "shelf_id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_issued_details_book_details_book_id",
                table: "issued_details",
                column: "book_id",
                principalTable: "book_details",
                principalColumn: "book_id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_issued_details_user_details_user_id",
                table: "issued_details",
                column: "user_id",
                principalTable: "user_details",
                principalColumn: "user_id",
                onDelete: ReferentialAction.SetNull);
        }
    }
}
