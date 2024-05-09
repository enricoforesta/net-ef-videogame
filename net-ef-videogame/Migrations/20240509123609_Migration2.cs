using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace net_ef_videogame.Migrations
{
    /// <inheritdoc />
    public partial class Migration2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SoftwareHouseVideogames",
                columns: table => new
                {
                    SoftwareHouseListSoftwareHouseId = table.Column<int>(type: "int", nullable: false),
                    VideogamesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SoftwareHouseVideogames", x => new { x.SoftwareHouseListSoftwareHouseId, x.VideogamesId });
                    table.ForeignKey(
                        name: "FK_SoftwareHouseVideogames_software_house_SoftwareHouseListSoftwareHouseId",
                        column: x => x.SoftwareHouseListSoftwareHouseId,
                        principalTable: "software_house",
                        principalColumn: "SoftwareHouseId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SoftwareHouseVideogames_videogames_VideogamesId",
                        column: x => x.VideogamesId,
                        principalTable: "videogames",
                        principalColumn: "VideogamesId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SoftwareHouseVideogames_VideogamesId",
                table: "SoftwareHouseVideogames",
                column: "VideogamesId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SoftwareHouseVideogames");
        }
    }
}
