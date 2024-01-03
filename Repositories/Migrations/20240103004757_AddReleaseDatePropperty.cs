using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repository.Migrations
{
    /// <inheritdoc />
    public partial class AddReleaseDatePropperty : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ReleaseDates_Movies_MovieId",
                table: "ReleaseDates");

            migrationBuilder.DropIndex(
                name: "IX_ReleaseDates_MovieId",
                table: "ReleaseDates");

            migrationBuilder.DropColumn(
                name: "MovieId",
                table: "ReleaseDates");

            migrationBuilder.CreateTable(
                name: "MovieReleaseDate",
                columns: table => new
                {
                    MoviesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ReleaseDateId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieReleaseDate", x => new { x.MoviesId, x.ReleaseDateId });
                    table.ForeignKey(
                        name: "FK_MovieReleaseDate_Movies_MoviesId",
                        column: x => x.MoviesId,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MovieReleaseDate_ReleaseDates_ReleaseDateId",
                        column: x => x.ReleaseDateId,
                        principalTable: "ReleaseDates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MovieReleaseDate_ReleaseDateId",
                table: "MovieReleaseDate",
                column: "ReleaseDateId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MovieReleaseDate");

            migrationBuilder.AddColumn<Guid>(
                name: "MovieId",
                table: "ReleaseDates",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ReleaseDates_MovieId",
                table: "ReleaseDates",
                column: "MovieId");

            migrationBuilder.AddForeignKey(
                name: "FK_ReleaseDates_Movies_MovieId",
                table: "ReleaseDates",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "Id");
        }
    }
}
