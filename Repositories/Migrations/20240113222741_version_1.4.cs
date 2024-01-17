using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repository.Migrations
{
    /// <inheritdoc />
    public partial class version_14 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_AccessLevel_LevelId",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "LevelId",
                table: "Users",
                newName: "AccessLevelId");

            migrationBuilder.RenameIndex(
                name: "IX_Users_LevelId",
                table: "Users",
                newName: "IX_Users_AccessLevelId");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Actors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_AccessLevel_AccessLevelId",
                table: "Users",
                column: "AccessLevelId",
                principalTable: "AccessLevel",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_AccessLevel_AccessLevelId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Actors");

            migrationBuilder.RenameColumn(
                name: "AccessLevelId",
                table: "Users",
                newName: "LevelId");

            migrationBuilder.RenameIndex(
                name: "IX_Users_AccessLevelId",
                table: "Users",
                newName: "IX_Users_LevelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_AccessLevel_LevelId",
                table: "Users",
                column: "LevelId",
                principalTable: "AccessLevel",
                principalColumn: "Id");
        }
    }
}
