using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HJMH.Tarifarios.Backend.Migrations
{
    /// <inheritdoc />
    public partial class initial3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CUPS",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Seccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Capitulo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Grupo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DescripcionGrupo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IncluyeGrupo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SimultaneoGrupo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExcluyeGrupo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Subgrupo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DescripcionSubgrupo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IncluyeSubgrupo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SimultaneoSubgrupo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExcluyeSubgrupo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Categoria = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DescripcionCategoria = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IncluyeCategoria = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SimultaneoCategoria = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExcluyeCategoria = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IncluyeCategoria2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SimultaneoCategoria2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExcluyeCategoria2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cobertura = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CoberturaPlanBeneficiosUPC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QueEs = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CUPS", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CUPS");
        }
    }
}
