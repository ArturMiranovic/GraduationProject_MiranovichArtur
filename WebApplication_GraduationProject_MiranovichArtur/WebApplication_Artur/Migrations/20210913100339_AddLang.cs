using Microsoft.EntityFrameworkCore.Migrations;
using WebApplication_Artur.EfStuff.Model.UserModel;

namespace WebApplication_Artur.Migrations
{
    public partial class AddLang : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Lang",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: (int)Lang.Eng);

            migrationBuilder.AddColumn<int>(
                name: "Role",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Page",
                table: "Bikes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                oldDefaultValue: "~/image/DefaultAvatar_V1.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Lang",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Role",
                table: "Users");

            migrationBuilder.AlterColumn<string>(
                name: "Page",
                table: "Bikes",
                type: "nvarchar(max)",
                nullable: true,
                defaultValue: "~/image/DefaultAvatar_V1.jpg",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
