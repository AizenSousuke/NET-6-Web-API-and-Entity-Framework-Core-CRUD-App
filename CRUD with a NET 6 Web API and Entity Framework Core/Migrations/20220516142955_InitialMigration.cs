using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CRUD_with_a_NET_6_Web_API_and_Entity_Framework_Core.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SuperHeroes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Place = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SuperHeroes", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "SuperHeroes",
                columns: new[] { "Id", "FirstName", "LastName", "Name", "Place" },
                values: new object[] { 1, "Peter", "Parker", "Spiderman", "New York" });

            migrationBuilder.InsertData(
                table: "SuperHeroes",
                columns: new[] { "Id", "FirstName", "LastName", "Name", "Place" },
                values: new object[] { 2, "Misaka", "Mikoto", "Misaka Mikoto", "Academy City" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SuperHeroes");
        }
    }
}
