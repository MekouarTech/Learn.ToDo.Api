using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Learn.ToDo.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class thirdMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ToDoCategories_ToDoDetails_ToDoDetailId",
                table: "ToDoCategories");

            migrationBuilder.DropForeignKey(
                name: "FK_ToDoDetails_UserDetails_UserDetailId",
                table: "ToDoDetails");

            migrationBuilder.RenameColumn(
                name: "UserDetailId",
                table: "ToDoDetails",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "ToDoDetails",
                newName: "TodoId");

            migrationBuilder.RenameIndex(
                name: "IX_ToDoDetails_UserDetailId",
                table: "ToDoDetails",
                newName: "IX_ToDoDetails_UserId");

            migrationBuilder.RenameColumn(
                name: "ToDoDetailId",
                table: "ToDoCategories",
                newName: "TodoId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "ToDoCategories",
                newName: "TodoCategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_ToDoCategories_ToDoDetailId",
                table: "ToDoCategories",
                newName: "IX_ToDoCategories_TodoId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Categories",
                newName: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_ToDoCategories_ToDoDetails_TodoId",
                table: "ToDoCategories",
                column: "TodoId",
                principalTable: "ToDoDetails",
                principalColumn: "TodoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ToDoDetails_UserDetails_UserId",
                table: "ToDoDetails",
                column: "UserId",
                principalTable: "UserDetails",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ToDoCategories_ToDoDetails_TodoId",
                table: "ToDoCategories");

            migrationBuilder.DropForeignKey(
                name: "FK_ToDoDetails_UserDetails_UserId",
                table: "ToDoDetails");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "ToDoDetails",
                newName: "UserDetailId");

            migrationBuilder.RenameColumn(
                name: "TodoId",
                table: "ToDoDetails",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_ToDoDetails_UserId",
                table: "ToDoDetails",
                newName: "IX_ToDoDetails_UserDetailId");

            migrationBuilder.RenameColumn(
                name: "TodoId",
                table: "ToDoCategories",
                newName: "ToDoDetailId");

            migrationBuilder.RenameColumn(
                name: "TodoCategoryId",
                table: "ToDoCategories",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_ToDoCategories_TodoId",
                table: "ToDoCategories",
                newName: "IX_ToDoCategories_ToDoDetailId");

            migrationBuilder.RenameColumn(
                name: "CategoryId",
                table: "Categories",
                newName: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ToDoCategories_ToDoDetails_ToDoDetailId",
                table: "ToDoCategories",
                column: "ToDoDetailId",
                principalTable: "ToDoDetails",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ToDoDetails_UserDetails_UserDetailId",
                table: "ToDoDetails",
                column: "UserDetailId",
                principalTable: "UserDetails",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
