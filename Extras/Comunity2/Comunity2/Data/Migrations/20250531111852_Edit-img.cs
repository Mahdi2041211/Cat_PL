using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Comunity2.Data.Migrations
{
    /// <inheritdoc />
    public partial class Editimg : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e211c2dc-799f-49fa-bdd6-205f562cc071");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fd1285a9-2014-4412-81b1-b0350ff61a09");

            migrationBuilder.AddColumn<byte[]>(
                name: "Picture",
                table: "Images",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "30b307aa-ac5e-4611-ae90-dc3ab7da499e", "36894e29-8002-48c0-9b51-bcef191bd4fc", "Admin", "admin" },
                    { "7f2c9f9c-6871-40a5-9e6d-07b8302c35db", "b8b33b60-64d2-4d2f-a078-0c4d34b933bf", "User", "user" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "30b307aa-ac5e-4611-ae90-dc3ab7da499e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7f2c9f9c-6871-40a5-9e6d-07b8302c35db");

            migrationBuilder.DropColumn(
                name: "Picture",
                table: "Images");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "e211c2dc-799f-49fa-bdd6-205f562cc071", "b3bdc7c3-d048-4e45-9386-5e9b6d613961", "User", "user" },
                    { "fd1285a9-2014-4412-81b1-b0350ff61a09", "0f0b7c05-962e-4655-b9bd-539e0b8f392d", "Admin", "admin" }
                });
        }
    }
}
