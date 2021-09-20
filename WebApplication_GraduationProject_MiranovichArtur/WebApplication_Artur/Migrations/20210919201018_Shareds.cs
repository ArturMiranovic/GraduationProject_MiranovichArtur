using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication_Artur.Migrations
{
    public partial class Shareds : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Switches_Bikes_Id",
                table: "Switches");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Switches",
                table: "Switches");

            migrationBuilder.RenameTable(
                name: "Switches",
                newName: "Shareds");

            migrationBuilder.RenameColumn(
                name: "Rearstars",
                table: "Shareds",
                newName: "WheelDiametr");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Shareds",
                table: "Shareds",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Shareds_Bikes_Id",
                table: "Shareds",
                column: "Id",
                principalTable: "Bikes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Shareds_Bikes_Id",
                table: "Shareds");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Shareds",
                table: "Shareds");

            migrationBuilder.RenameTable(
                name: "Shareds",
                newName: "Switches");

            migrationBuilder.RenameColumn(
                name: "WheelDiametr",
                table: "Switches",
                newName: "Rearstars");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Switches",
                table: "Switches",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Switches_Bikes_Id",
                table: "Switches",
                column: "Id",
                principalTable: "Bikes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
