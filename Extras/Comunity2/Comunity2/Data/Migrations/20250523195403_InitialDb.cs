using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Comunity2.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "posts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Post_Date_Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Count_Likes = table.Column<int>(type: "int", nullable: false),
                    User_Id = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_posts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_posts_AspNetUsers_User_Id",
                        column: x => x.User_Id,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Quis",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: false),
                    User_Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Quis_Date_Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quis", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Quis_AspNetUsers_User_Id",
                        column: x => x.User_Id,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "comments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    User_Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Comment_Date_Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Count_Likes = table.Column<int>(type: "int", nullable: false),
                    Post_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_comments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_comments_AspNetUsers_User_Id",
                        column: x => x.User_Id,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_comments_posts_Post_Id",
                        column: x => x.Post_Id,
                        principalTable: "posts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Post_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Images_posts_Post_Id",
                        column: x => x.Post_Id,
                        principalTable: "posts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DoQuis",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    User_Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DoQis_Date_Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Mark = table.Column<double>(type: "float", nullable: false),
                    Quis_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DoQuis", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DoQuis_AspNetUsers_User_Id",
                        column: x => x.User_Id,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DoQuis_Quis_Quis_Id",
                        column: x => x.Quis_Id,
                        principalTable: "Quis",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Quistions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Answer1 = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Answer2 = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Answer3 = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Answer4 = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Correct_Answer = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Quis_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quistions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Quistions_Quis_Quis_Id",
                        column: x => x.Quis_Id,
                        principalTable: "Quis",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Likies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Like_Date_Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    User_Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Status_Like = table.Column<bool>(type: "bit", nullable: false),
                    Post_Id = table.Column<int>(type: "int", nullable: false),
                    Comment_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Likies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Likies_AspNetUsers_User_Id",
                        column: x => x.User_Id,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Likies_comments_Comment_Id",
                        column: x => x.Comment_Id,
                        principalTable: "comments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Likies_posts_Post_Id",
                        column: x => x.Post_Id,
                        principalTable: "posts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_comments_Post_Id",
                table: "comments",
                column: "Post_Id");

            migrationBuilder.CreateIndex(
                name: "IX_comments_User_Id",
                table: "comments",
                column: "User_Id");

            migrationBuilder.CreateIndex(
                name: "IX_DoQuis_Quis_Id",
                table: "DoQuis",
                column: "Quis_Id");

            migrationBuilder.CreateIndex(
                name: "IX_DoQuis_User_Id",
                table: "DoQuis",
                column: "User_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Images_Post_Id",
                table: "Images",
                column: "Post_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Likies_Comment_Id",
                table: "Likies",
                column: "Comment_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Likies_Post_Id",
                table: "Likies",
                column: "Post_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Likies_User_Id",
                table: "Likies",
                column: "User_Id");

            migrationBuilder.CreateIndex(
                name: "IX_posts_User_Id",
                table: "posts",
                column: "User_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Quis_User_Id",
                table: "Quis",
                column: "User_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Quistions_Quis_Id",
                table: "Quistions",
                column: "Quis_Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DoQuis");

            migrationBuilder.DropTable(
                name: "Images");

            migrationBuilder.DropTable(
                name: "Likies");

            migrationBuilder.DropTable(
                name: "Quistions");

            migrationBuilder.DropTable(
                name: "comments");

            migrationBuilder.DropTable(
                name: "Quis");

            migrationBuilder.DropTable(
                name: "posts");
        }
    }
}
