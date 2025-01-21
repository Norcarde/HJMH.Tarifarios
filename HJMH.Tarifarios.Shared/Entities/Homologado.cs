namespace HJMH.Tarifarios.Shared.Entities
{
    public class Homologado
    {
        public int CupsId { get; set; }
        public ClasificacionUnicaProcedimientos Cups { get; set; }

        public int SoatId { get; set; }
        public Soat Soat { get; set; }

        public string Observacion { get; set; }
    }
}