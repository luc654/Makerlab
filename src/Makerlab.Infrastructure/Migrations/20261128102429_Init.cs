using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Makerlab.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Apparaten",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Naam = table.Column<string>(type: "TEXT", nullable: false),
                    Locatie = table.Column<string>(type: "TEXT", nullable: false),
                    Status = table.Column<int>(type: "INTEGER", nullable: false),
                    Discriminator = table.Column<string>(type: "TEXT", maxLength: 8, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Apparaten", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Apparaten",
                columns: new[] { "Id", "Discriminator", "Locatie", "Naam", "Status" },
                values: new object[] { 1, "Snijder", "Werkplaats A", "Lasersnijder 1", 0 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Apparaten");
        }
    }
}
