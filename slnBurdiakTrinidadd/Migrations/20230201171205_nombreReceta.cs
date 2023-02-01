using Microsoft.EntityFrameworkCore.Migrations;

namespace slnBurdiakTrinidad.Migrations
{
    public partial class nombreReceta : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Nombre",
                table: "Recetas",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Nombre",
                table: "Recetas");
        }
    }
}
