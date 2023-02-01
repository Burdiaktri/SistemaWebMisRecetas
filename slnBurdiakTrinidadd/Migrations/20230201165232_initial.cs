using Microsoft.EntityFrameworkCore.Migrations;

namespace slnBurdiakTrinidad.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Recetas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Categoria = table.Column<string>(nullable: false),
                    Ingredientes = table.Column<string>(nullable: false),
                    Instrucciones = table.Column<string>(nullable: false),
                    NombreAutor = table.Column<string>(nullable: false),
                    ApellidoAutor = table.Column<string>(nullable: false),
                    EdadAutor = table.Column<int>(nullable: false),
                    EmailAutor = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recetas", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Recetas");
        }
    }
}
