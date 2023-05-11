using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Task1.Migrations
{
    public partial class markaModelRelationAdd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MarkaId",
                table: "Models",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Models_MarkaId",
                table: "Models",
                column: "MarkaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Models_Markas_MarkaId",
                table: "Models",
                column: "MarkaId",
                principalTable: "Markas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Models_Markas_MarkaId",
                table: "Models");

            migrationBuilder.DropIndex(
                name: "IX_Models_MarkaId",
                table: "Models");

            migrationBuilder.DropColumn(
                name: "MarkaId",
                table: "Models");
        }
    }
}
