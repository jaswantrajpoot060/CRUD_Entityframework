using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CRUD_Entityframework.Migrations
{
    /// <inheritdoc />
    public partial class AddedLanguageTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LanguageId",
                table: "tblBook",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "tblLanguage",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblLanguage", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tblBook_LanguageId",
                table: "tblBook",
                column: "LanguageId");

            migrationBuilder.AddForeignKey(
                name: "FK_tblBook_tblLanguage_LanguageId",
                table: "tblBook",
                column: "LanguageId",
                principalTable: "tblLanguage",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tblBook_tblLanguage_LanguageId",
                table: "tblBook");

            migrationBuilder.DropTable(
                name: "tblLanguage");

            migrationBuilder.DropIndex(
                name: "IX_tblBook_LanguageId",
                table: "tblBook");

            migrationBuilder.DropColumn(
                name: "LanguageId",
                table: "tblBook");
        }
    }
}
