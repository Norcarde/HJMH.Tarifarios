using System.ComponentModel.DataAnnotations;

namespace HJMH.Tarifarios.Shared.Entities
{
    public class Soat
    {
        [Key]
        public int Id { get; set; }

        public string? Codigo { get; set; }
        public string? Descripcion { get; set; }
        public string? Clase { get; set; }
        public string? Capitulo { get; set; }
        public string? Articulo { get; set; }
        public string? Paragrafos { get; set; }
        public string? Grupo { get; set; }
        public string? Subgrupo { get; set; }
        public float SMLV { get; set; }
        public float UVT { get; set; }
        public float UVB { get; set; }
        public float Diferencial { get; set; }

        public ICollection<Homologado> Homologadores { get; set; } = new List<Homologado>();
    }
}