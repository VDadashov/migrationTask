using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Task1.Migrations
{
    public partial class carDbUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ModellId",
                table: "Cars",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Cars_ModellId",
                table: "Cars",
                column: "ModellId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_Models_ModellId",
                table: "Cars",
                column: "ModellId",
                principalTable: "Models",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cars_Models_ModellId",
                table: "Cars");

            migrationBuilder.DropIndex(
                name: "IX_Cars_ModellId",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "ModellId",
                table: "Cars");
        }
    }
}
