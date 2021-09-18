using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication_Artur.Migrations
{
    public partial class NewAwatarUrl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Awatar",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                defaultValue: "/image/defolt/DefaultAvatar_V2.png",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                oldDefaultValue: "/image/DefaultAvatar_V2.png");

            migrationBuilder.AlterColumn<string>(
                name: "Page",
                table: "Bikes",
                type: "nvarchar(max)",
                nullable: true,
                defaultValue: "/image/defolt/defaultBike1.png",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                oldDefaultValue: "/image/defaultBike1.png");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Awatar",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                defaultValue: "/image/DefaultAvatar_V2.png",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                oldDefaultValue: "/image/defolt/DefaultAvatar_V2.png");

            migrationBuilder.AlterColumn<string>(
                name: "Page",
                table: "Bikes",
                type: "nvarchar(max)",
                nullable: true,
                defaultValue: "/image/defaultBike1.png",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                oldDefaultValue: "/image/defolt/defaultBike1.png");
        }
    }
}
