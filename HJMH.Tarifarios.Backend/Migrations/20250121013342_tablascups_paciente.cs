using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HJMH.Tarifarios.Backend.Migrations
{
    /// <inheritdoc />
    public partial class tablascups_paciente : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PacientesEmssanar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Medicina = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Odontología = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Medicamentos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PyP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdAfiliado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdSubsidiado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TipoIdentificacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumeroIdentificacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrimerNombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SegundoNombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrimerApellido = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SegundoApellido = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sexo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaNacimiento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Edad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrigenEtnico = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrientacionSexual = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrigenAfiliado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PuntajeSisben = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NivelSisben = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FichaSisben = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InicioCobertura = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FinCobertura = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CausaRetiro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Plan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TipoDiscapacidad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CodigoDepartamentoResidencia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CodigoMunicipioResidencia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MunicipioResidencia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CodigoGrupoPoblacional = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GrupoPoblacional = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GrupoEdadUPC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CicloVida = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegistroUnicoVictimas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HechoVictimizanteRUV = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RangoSalarial = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DescripcionRangoSalarial = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NombreIPS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DireccionResidencia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Zona = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LocalidadComuna = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Barrio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TelefonoFijo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Celular = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Celular2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CorreoElectronico = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CorreoElectronico2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CodigoMunicipioResidenciaOrigen = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MunicipioResidenciaOrigen = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PortabilidadVigente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaInicioEfectivaPortabilidadVigente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaFinEfectivaPortabiliadVigente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaBaseDatos = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PacientesEmssanar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Soat",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Codigo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Clase = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Capitulo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Articulo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Paragrafos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Grupo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Subgrupo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SMLV = table.Column<float>(type: "real", nullable: false),
                    UVT = table.Column<float>(type: "real", nullable: false),
                    UVB = table.Column<float>(type: "real", nullable: false),
                    Diferencial = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Soat", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Homologados",
                columns: table => new
                {
                    CupsId = table.Column<int>(type: "int", nullable: false),
                    SoatId = table.Column<int>(type: "int", nullable: false),
                    Observacion = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Homologados", x => new { x.CupsId, x.SoatId });
                    table.ForeignKey(
                        name: "FK_Homologados_CUPS_CupsId",
                        column: x => x.CupsId,
                        principalTable: "CUPS",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Homologados_Soat_SoatId",
                        column: x => x.SoatId,
                        principalTable: "Soat",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Homologados_SoatId",
                table: "Homologados",
                column: "SoatId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Homologados");

            migrationBuilder.DropTable(
                name: "PacientesEmssanar");

            migrationBuilder.DropTable(
                name: "Soat");
        }
    }
}
