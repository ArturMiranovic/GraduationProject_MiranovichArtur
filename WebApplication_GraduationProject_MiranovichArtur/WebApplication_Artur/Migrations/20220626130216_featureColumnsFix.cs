using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication_Artur.Migrations
{
    public partial class featureColumnsFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "WheelDiameter",
                table: "Shareds",
                newName: "RearChainrings");

            migrationBuilder.RenameColumn(
                name: "Chainrings",
                table: "Shareds",
                newName: "FrontChainrings");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "RearChainrings",
                table: "Shareds",
                newName: "WheelDiameter");

            migrationBuilder.RenameColumn(
                name: "FrontChainrings",
                table: "Shareds",
                newName: "Chainrings");
        }
    }
}
