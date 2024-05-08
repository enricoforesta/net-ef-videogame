using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace net_ef_videogame.Migrations
{
    /// <inheritdoc />
    public partial class Migration1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "software_house",
                columns: table => new
                {
                    SoftwareHouseId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_software_house", x => x.SoftwareHouseId);
                });

            migrationBuilder.CreateTable(
                name: "videogames",
                columns: table => new
                {
                    VideogamesId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Overview = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    release_date = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    created_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    update_at = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_videogames", x => x.VideogamesId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_software_house_SoftwareHouseId",
                table: "software_house",
                column: "SoftwareHouseId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_videogames_VideogamesId",
                table: "videogames",
                column: "VideogamesId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "software_house");

            migrationBuilder.DropTable(
                name: "videogames");
        }
    }
}
