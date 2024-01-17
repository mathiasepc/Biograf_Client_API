using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repository.Migrations
{
    /// <inheritdoc />
    public partial class version10 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Level_LevelId",
                table: "Users");

            migrationBuilder.DropTable(
                name: "Level");

            migrationBuilder.DropColumn(
                name: "CinemaId",
                table: "Users");

            migrationBuilder.CreateTable(
                name: "AccessLevel",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccessLevel", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Users_AccessLevel_LevelId",
                table: "Users",
                column: "LevelId",
                principalTable: "AccessLevel",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_AccessLevel_LevelId",
                table: "Users");

            migrationBuilder.DropTable(
                name: "AccessLevel");

            migrationBuilder.AddColumn<Guid>(
                name: "CinemaId",
                table: "Users",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Level",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Level", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Level_LevelId",
                table: "Users",
                column: "LevelId",
                principalTable: "Level",
                principalColumn: "Id");
        }
    }
}
