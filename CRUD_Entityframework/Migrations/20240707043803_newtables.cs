using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CRUD_Entityframework.Migrations
{
    /// <inheritdoc />
    public partial class newtables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tblCurrency",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblCurrency", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tblBookPrice",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookId = table.Column<int>(type: "int", nullable: false),
                    CurrencyId = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblBookPrice", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tblBookPrice_tblBook_BookId",
                        column: x => x.BookId,
                        principalTable: "tblBook",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tblBookPrice_tblCurrency_CurrencyId",
                        column: x => x.CurrencyId,
                        principalTable: "tblCurrency",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "tblCurrency",
                columns: new[] { "Id", "Description", "Title" },
                values: new object[,]
                {
                    { 1, "Indian INR", "INR" },
                    { 2, "Dollar", "Dollar" },
                    { 3, "Euro", "Euro" },
                    { 4, "Diner", "Diner" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_tblBookPrice_BookId",
                table: "tblBookPrice",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_tblBookPrice_CurrencyId",
                table: "tblBookPrice",
                column: "CurrencyId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tblBookPrice");

            migrationBuilder.DropTable(
                name: "tblCurrency");
        }
    }
}
