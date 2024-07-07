using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CRUD_Entityframework.Migrations
{
    /// <inheritdoc />
    public partial class masterdatalanguage : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "tblLanguage",
                columns: new[] { "Id", "Description", "Title" },
                values: new object[,]
                {
                    { 1, "Hindi", "Hindi" },
                    { 2, "English", "English" },
                    { 3, "Urdu", "Urdu" },
                    { 4, "Panjabi", "Panjabi" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "tblLanguage",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "tblLanguage",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "tblLanguage",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "tblLanguage",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
