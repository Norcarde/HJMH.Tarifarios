using System.ComponentModel.DataAnnotations;

namespace HJMH.Tarifarios.Shared.Entities
{
    public class PacienteEmssanar
    {
        [Key]
        public int Id { get; set; }

        public string? Medicina { get; set; }
        public string? Odontología { get; set; }
        public string? Medicamentos { get; set; }
        public string? PyP { get; set; }
        public string? IdAfiliado { get; set; }
        public string? IdSubsidiado { get; set; }
        public string? TipoIdentificacion { get; set; }
        public string? NumeroIdentificacion { get; set; }
        public string? PrimerNombre { get; set; }
        public string? SegundoNombre { get; set; }
        public string? PrimerApellido { get; set; }
        public string? SegundoApellido { get; set; }
        public string? Sexo { get; set; }
        public string? FechaNacimiento { get; set; }
        public string? Edad { get; set; }
        public string? OrigenEtnico { get; set; }
        public string? OrientacionSexual { get; set; }
        public string? OrigenAfiliado { get; set; }
        public string? PuntajeSisben { get; set; }
        public string? NivelSisben { get; set; }
        public string? FichaSisben { get; set; }
        public string? InicioCobertura { get; set; }
        public string? FinCobertura { get; set; }
        public string? CausaRetiro { get; set; }
        public string? Plan { get; set; }
        public string? TipoDiscapacidad { get; set; }
        public string? CodigoDepartamentoResidencia { get; set; }
        public string? CodigoMunicipioResidencia { get; set; }
        public string? MunicipioResidencia { get; set; }
        public string? CodigoGrupoPoblacional { get; set; }
        public string? GrupoPoblacional { get; set; }
        public string? GrupoEdadUPC { get; set; }
        public string? CicloVida { get; set; }
        public string? RegistroUnicoVictimas { get; set; }
        public string? HechoVictimizanteRUV { get; set; }
        public string? RangoSalarial { get; set; }
        public string? DescripcionRangoSalarial { get; set; }
        public string? NombreIPS { get; set; }
        public string? DireccionResidencia { get; set; }
        public string? Zona { get; set; }
        public string? LocalidadComuna { get; set; }
        public string? Barrio { get; set; }
        public string? TelefonoFijo { get; set; }
        public string? Celular { get; set; }
        public string? Celular2 { get; set; }
        public string? CorreoElectronico { get; set; }
        public string? CorreoElectronico2 { get; set; }
        public string? CodigoMunicipioResidenciaOrigen { get; set; }
        public string? MunicipioResidenciaOrigen { get; set; }
        public string? PortabilidadVigente { get; set; }
        public string? FechaInicioEfectivaPortabilidadVigente { get; set; }
        public string? FechaFinEfectivaPortabiliadVigente { get; set; }

        public DateTime? FechaBaseDatos { get; set; } = DateTime.Now;
    }
}