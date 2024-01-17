using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repository.Migrations
{
    /// <inheritdoc />
    public partial class CinemaUpdated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Cinemas_CinemaId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_CinemaId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "CinemaId",
                table: "Users");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "CinemaId",
                table: "Users",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_CinemaId",
                table: "Users",
                column: "CinemaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Cinemas_CinemaId",
                table: "Users",
                column: "CinemaId",
                principalTable: "Cinemas",
                principalColumn: "Id");
        }
    }
}
