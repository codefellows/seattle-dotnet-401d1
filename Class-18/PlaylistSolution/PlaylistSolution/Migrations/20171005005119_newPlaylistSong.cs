using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace PlaylistSolution.Migrations
{
    public partial class newPlaylistSong : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PlaylistSongs",
                columns: table => new
                {
                    playlistID = table.Column<int>(type: "int", nullable: false),
                    songID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlaylistSongs", x => new { x.playlistID, x.songID });
                    table.ForeignKey(
                        name: "FK_PlaylistSongs_Playlist_playlistID",
                        column: x => x.playlistID,
                        principalTable: "Playlist",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlaylistSongs_Song_songID",
                        column: x => x.songID,
                        principalTable: "Song",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PlaylistSongs_songID",
                table: "PlaylistSongs",
                column: "songID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PlaylistSongs");
        }
    }
}
