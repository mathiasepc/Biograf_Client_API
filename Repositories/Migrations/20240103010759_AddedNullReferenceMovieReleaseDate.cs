using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repository.Migrations
{
    /// <inheritdoc />
    public partial class AddedNullReferenceMovieReleaseDate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MovieReleaseDate_Movies_ReleaseDateId",
                table: "MovieReleaseDate");

            migrationBuilder.DropForeignKey(
                name: "FK_MovieReleaseDate_ReleaseDates_MovieId",
                table: "MovieReleaseDate");

            migrationBuilder.RenameColumn(
                name: "MovieId",
                table: "MovieReleaseDate",
                newName: "MoviesId");

            migrationBuilder.AddForeignKey(
                name: "FK_MovieReleaseDate_Movies_MoviesId",
                table: "MovieReleaseDate",
                column: "MoviesId",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MovieReleaseDate_ReleaseDates_ReleaseDateId",
                table: "MovieReleaseDate",
                column: "ReleaseDateId",
                principalTable: "ReleaseDates",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MovieReleaseDate_Movies_MoviesId",
                table: "MovieReleaseDate");

            migrationBuilder.DropForeignKey(
                name: "FK_MovieReleaseDate_ReleaseDates_ReleaseDateId",
                table: "MovieReleaseDate");

            migrationBuilder.RenameColumn(
                name: "MoviesId",
                table: "MovieReleaseDate",
                newName: "MovieId");

            migrationBuilder.AddForeignKey(
                name: "FK_MovieReleaseDate_Movies_ReleaseDateId",
                table: "MovieReleaseDate",
                column: "ReleaseDateId",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MovieReleaseDate_ReleaseDates_MovieId",
                table: "MovieReleaseDate",
                column: "MovieId",
                principalTable: "ReleaseDates",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
