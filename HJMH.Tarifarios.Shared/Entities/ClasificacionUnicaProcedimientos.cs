using System.ComponentModel.DataAnnotations;

namespace HJMH.Tarifarios.Shared.Entities
{
    public class ClasificacionUnicaProcedimientos
    {
        [Key]
        public int Id { get; set; }

        public string? CUPS { get; set; } = null!;
        public string? Descripcion { get; set; }
        public string? Seccion { get; set; }
        public string? Capitulo { get; set; }
        public string? Grupo { get; set; }
        public string? DescripcionGrupo { get; set; }
        public string? IncluyeGrupo { get; set; }
        public string? SimultaneoGrupo { get; set; }
        public string? ExcluyeGrupo { get; set; }
        public string? Subgrupo { get; set; }
        public string? DescripcionSubgrupo { get; set; }
        public string? IncluyeSubgrupo { get; set; }
        public string? SimultaneoSubgrupo { get; set; }
        public string? ExcluyeSubgrupo { get; set; }
        public string? Categoria { get; set; }
        public string? DescripcionCategoria { get; set; }
        public string? IncluyeCategoria { get; set; }
        public string? SimultaneoCategoria { get; set; }
        public string? ExcluyeCategoria { get; set; }
        public string? IncluyeCategoria2 { get; set; }
        public string? SimultaneoCategoria2 { get; set; }
        public string? ExcluyeCategoria2 { get; set; }
        public string? Cobertura { get; set; }
        public string? CoberturaPlanBeneficiosUPC { get; set; }
        public string? QueEs { get; set; }
    }
}