using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication_Artur.Migrations
{
    public partial class OneBikeManyUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BikeUser_Bikes_MyBikesId",
                table: "BikeUser");

            migrationBuilder.DropForeignKey(
                name: "FK_BikeUser_Users_OwnerId",
                table: "BikeUser");

            migrationBuilder.DropTable(
                name: "BikeUser1");

            migrationBuilder.RenameColumn(
                name: "OwnerId",
                table: "BikeUser",
                newName: "PotentialBuyerId");

            migrationBuilder.RenameColumn(
                name: "MyBikesId",
                table: "BikeUser",
                newName: "LikeBikesId");

            migrationBuilder.RenameIndex(
                name: "IX_BikeUser_OwnerId",
                table: "BikeUser",
                newName: "IX_BikeUser_PotentialBuyerId");

            migrationBuilder.AlterColumn<long>(
                name: "BikeSize",
                table: "Bikes",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<long>(
                name: "OwnerId",
                table: "Bikes",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Bikes_OwnerId",
                table: "Bikes",
                column: "OwnerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Bikes_Users_OwnerId",
                table: "Bikes",
                column: "OwnerId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BikeUser_Bikes_LikeBikesId",
                table: "BikeUser",
                column: "LikeBikesId",
                principalTable: "Bikes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BikeUser_Users_PotentialBuyerId",
                table: "BikeUser",
                column: "PotentialBuyerId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bikes_Users_OwnerId",
                table: "Bikes");

            migrationBuilder.DropForeignKey(
                name: "FK_BikeUser_Bikes_LikeBikesId",
                table: "BikeUser");

            migrationBuilder.DropForeignKey(
                name: "FK_BikeUser_Users_PotentialBuyerId",
                table: "BikeUser");

            migrationBuilder.DropIndex(
                name: "IX_Bikes_OwnerId",
                table: "Bikes");

            migrationBuilder.DropColumn(
                name: "OwnerId",
                table: "Bikes");

            migrationBuilder.RenameColumn(
                name: "PotentialBuyerId",
                table: "BikeUser",
                newName: "OwnerId");

            migrationBuilder.RenameColumn(
                name: "LikeBikesId",
                table: "BikeUser",
                newName: "MyBikesId");

            migrationBuilder.RenameIndex(
                name: "IX_BikeUser_PotentialBuyerId",
                table: "BikeUser",
                newName: "IX_BikeUser_OwnerId");

            migrationBuilder.AlterColumn<int>(
                name: "BikeSize",
                table: "Bikes",
                type: "int",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.CreateTable(
                name: "BikeUser1",
                columns: table => new
                {
                    LikeBikesId = table.Column<long>(type: "bigint", nullable: false),
                    PotentialBuyerId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BikeUser1", x => new { x.LikeBikesId, x.PotentialBuyerId });
                    table.ForeignKey(
                        name: "FK_BikeUser1_Bikes_LikeBikesId",
                        column: x => x.LikeBikesId,
                        principalTable: "Bikes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BikeUser1_Users_PotentialBuyerId",
                        column: x => x.PotentialBuyerId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BikeUser1_PotentialBuyerId",
                table: "BikeUser1",
                column: "PotentialBuyerId");

            migrationBuilder.AddForeignKey(
                name: "FK_BikeUser_Bikes_MyBikesId",
                table: "BikeUser",
                column: "MyBikesId",
                principalTable: "Bikes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BikeUser_Users_OwnerId",
                table: "BikeUser",
                column: "OwnerId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
