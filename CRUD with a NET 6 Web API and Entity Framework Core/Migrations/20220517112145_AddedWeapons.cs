using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CRUD_with_a_NET_6_Web_API_and_Entity_Framework_Core.Migrations
{
    public partial class AddedWeapons : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "WeaponId",
                table: "SuperHeroes",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Weapons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: true),
                    Damage = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Weapons", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Weapons",
                columns: new[] { "Id", "Damage", "Name", "Type" },
                values: new object[] { 1, 1, "Sword", 0 });

            migrationBuilder.InsertData(
                table: "Weapons",
                columns: new[] { "Id", "Damage", "Name", "Type" },
                values: new object[] { 2, 1, "Gun", 1 });

            migrationBuilder.CreateIndex(
                name: "IX_SuperHeroes_WeaponId",
                table: "SuperHeroes",
                column: "WeaponId");

            migrationBuilder.AddForeignKey(
                name: "FK_SuperHeroes_Weapons_WeaponId",
                table: "SuperHeroes",
                column: "WeaponId",
                principalTable: "Weapons",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SuperHeroes_Weapons_WeaponId",
                table: "SuperHeroes");

            migrationBuilder.DropTable(
                name: "Weapons");

            migrationBuilder.DropIndex(
                name: "IX_SuperHeroes_WeaponId",
                table: "SuperHeroes");

            migrationBuilder.DropColumn(
                name: "WeaponId",
                table: "SuperHeroes");
        }
    }
}
