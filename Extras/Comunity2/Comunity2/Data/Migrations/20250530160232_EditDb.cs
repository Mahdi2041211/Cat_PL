using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Comunity2.Data.Migrations
{
    /// <inheritdoc />
    public partial class EditDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "e211c2dc-799f-49fa-bdd6-205f562cc071", "b3bdc7c3-d048-4e45-9386-5e9b6d613961", "User", "user" },
                    { "fd1285a9-2014-4412-81b1-b0350ff61a09", "0f0b7c05-962e-4655-b9bd-539e0b8f392d", "Admin", "admin" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e211c2dc-799f-49fa-bdd6-205f562cc071");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fd1285a9-2014-4412-81b1-b0350ff61a09");
        }
    }
}
