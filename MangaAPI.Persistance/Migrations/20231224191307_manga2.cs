using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MangaAPI.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class manga2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "MangaId",
                table: "Chapters",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Chapters_MangaId",
                table: "Chapters",
                column: "MangaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Chapters_Mangas_MangaId",
                table: "Chapters",
                column: "MangaId",
                principalTable: "Mangas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Chapters_Mangas_MangaId",
                table: "Chapters");

            migrationBuilder.DropIndex(
                name: "IX_Chapters_MangaId",
                table: "Chapters");

            migrationBuilder.DropColumn(
                name: "MangaId",
                table: "Chapters");
        }
    }
}
