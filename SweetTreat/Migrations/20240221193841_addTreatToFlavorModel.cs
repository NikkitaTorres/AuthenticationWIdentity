using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SweetTreat.Migrations
{
    public partial class addTreatToFlavorModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Treats_FlavorId",
                table: "Treats");

            migrationBuilder.UpdateData(
                table: "Flavors",
                keyColumn: "Name",
                keyValue: null,
                column: "Name",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Flavors",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Flavors",
                type: "varchar(255)",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Treats_FlavorId",
                table: "Treats",
                column: "FlavorId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Flavors_UserId",
                table: "Flavors",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Flavors_AspNetUsers_UserId",
                table: "Flavors",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Flavors_AspNetUsers_UserId",
                table: "Flavors");

            migrationBuilder.DropIndex(
                name: "IX_Treats_FlavorId",
                table: "Treats");

            migrationBuilder.DropIndex(
                name: "IX_Flavors_UserId",
                table: "Flavors");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Flavors");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Flavors",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Treats_FlavorId",
                table: "Treats",
                column: "FlavorId");
        }
    }
}
