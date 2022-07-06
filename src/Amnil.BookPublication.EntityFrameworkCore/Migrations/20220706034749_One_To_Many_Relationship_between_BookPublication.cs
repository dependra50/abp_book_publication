using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Amnil.BookPublication.Migrations
{
    public partial class One_To_Many_Relationship_between_BookPublication : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "PublicationId1",
                table: "AppBooks",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AppBooks_PublicationId1",
                table: "AppBooks",
                column: "PublicationId1");

            migrationBuilder.AddForeignKey(
                name: "FK_AppBooks_AppPublication_PublicationId1",
                table: "AppBooks",
                column: "PublicationId1",
                principalTable: "AppPublication",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppBooks_AppPublication_PublicationId1",
                table: "AppBooks");

            migrationBuilder.DropIndex(
                name: "IX_AppBooks_PublicationId1",
                table: "AppBooks");

            migrationBuilder.DropColumn(
                name: "PublicationId1",
                table: "AppBooks");
        }
    }
}
