using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibraryManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class migration1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "category_details",
                columns: table => new
                {
                    categoryid = table.Column<int>(name: "category_id", type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    categoryname = table.Column<string>(name: "category_name", type: "varchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_category_details", x => x.categoryid);
                });

            migrationBuilder.CreateTable(
                name: "shelf_details",
                columns: table => new
                {
                    shelfid = table.Column<int>(name: "shelf_id", type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    shelffloor = table.Column<string>(name: "shelf_floor", type: "varchar(20)", nullable: false),
                    shelfnumber = table.Column<int>(name: "shelf_number", type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_shelf_details", x => x.shelfid);
                });

            migrationBuilder.CreateTable(
                name: "user_details",
                columns: table => new
                {
                    userid = table.Column<int>(name: "user_id", type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    username = table.Column<string>(name: "user_name", type: "varchar(50)", nullable: false),
                    usergender = table.Column<string>(name: "user_gender", type: "varchar(10)", nullable: false),
                    userdob = table.Column<DateTime>(name: "user_dob", type: "Date", nullable: false),
                    usertype = table.Column<string>(name: "user_type", type: "varchar(15)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user_details", x => x.userid);
                });

            migrationBuilder.CreateTable(
                name: "book_details",
                columns: table => new
                {
                    bookid = table.Column<int>(name: "book_id", type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    booktitle = table.Column<string>(name: "book_title", type: "varchar(100)", nullable: false),
                    bookauthor = table.Column<string>(name: "book_author", type: "varchar(100)", nullable: false),
                    bookreleaseyear = table.Column<int>(name: "book_release_year", type: "int", nullable: false),
                    categoryid = table.Column<int>(name: "category_id", type: "int", nullable: true),
                    ShelfID = table.Column<int>(name: "Shelf_ID", type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_book_details", x => x.bookid);
                    table.ForeignKey(
                        name: "FK_book_details_category_details_category_id",
                        column: x => x.categoryid,
                        principalTable: "category_details",
                        principalColumn: "category_id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_book_details_shelf_details_Shelf_ID",
                        column: x => x.ShelfID,
                        principalTable: "shelf_details",
                        principalColumn: "shelf_id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "issued_details",
                columns: table => new
                {
                    issuedid = table.Column<int>(name: "issued_id", type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    bookid = table.Column<int>(name: "book_id", type: "int", nullable: true),
                    userid = table.Column<int>(name: "user_id", type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_issued_details", x => x.issuedid);
                    table.ForeignKey(
                        name: "FK_issued_details_book_details_book_id",
                        column: x => x.bookid,
                        principalTable: "book_details",
                        principalColumn: "book_id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_issued_details_user_details_user_id",
                        column: x => x.userid,
                        principalTable: "user_details",
                        principalColumn: "user_id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateIndex(
                name: "IX_book_details_category_id",
                table: "book_details",
                column: "category_id");

            migrationBuilder.CreateIndex(
                name: "IX_book_details_Shelf_ID",
                table: "book_details",
                column: "Shelf_ID");

            migrationBuilder.CreateIndex(
                name: "IX_issued_details_book_id",
                table: "issued_details",
                column: "book_id");

            migrationBuilder.CreateIndex(
                name: "IX_issued_details_user_id",
                table: "issued_details",
                column: "user_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "issued_details");

            migrationBuilder.DropTable(
                name: "book_details");

            migrationBuilder.DropTable(
                name: "user_details");

            migrationBuilder.DropTable(
                name: "category_details");

            migrationBuilder.DropTable(
                name: "shelf_details");
        }
    }
}
