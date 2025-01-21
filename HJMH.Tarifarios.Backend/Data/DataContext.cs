using HJMH.Tarifarios.Shared.Entities;
using Microsoft.EntityFrameworkCore;

namespace HJMH.Tarifarios.Backend.Data
{
    /// <summary>
    /// Representa el contexto de datos para la aplicación.
    /// </summary>
    public class DataContext : DbContext
    {
        /// <summary>
        /// Obtiene o establece el conjunto de datos de Clasificación Única de Procedimientos.
        /// </summary>
        public DbSet<ClasificacionUnicaProcedimientos> CUPS { get; set; }

        /// <summary>
        /// Obtiene o establece el conjunto de datos de SOAT.
        /// </summary>
        public DbSet<Soat> Soat { get; set; }

        /// <summary>
        /// Obtiene o establece el conjunto de datos de Homologados.
        /// </summary>
        public DbSet<Homologado> Homologados { get; set; }

        /// <summary>
        /// Obtiene o establece el conjunto de datos de Pacientes Emssanar.
        /// </summary>
        public DbSet<PacienteEmssanar> PacientesEmssanar { get; set; }

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="DataContext"/>.
        /// </summary>
        /// <param name="options">Las opciones para este contexto.</param>
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        /// <summary>
        /// Configura el modelo que se va a usar con este contexto.
        /// </summary>
        /// <param name="modelBuilder">El generador de modelos que se va a usar para configurar el modelo.</param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Homologado>()
                .HasKey(h => new { h.CupsId, h.SoatId });

            modelBuilder.Entity<Homologado>()
                .HasOne(h => h.Cups)
                .WithMany(c => c.Homologadores)
                .HasForeignKey(h => h.CupsId);

            modelBuilder.Entity<Homologado>()
                .HasOne(h => h.Soat)
                .WithMany(s => s.Homologadores)
                .HasForeignKey(h => h.SoatId);

            modelBuilder.Entity<PacienteEmssanar>()
                .Property(p => p.FechaBaseDatos)
                .HasDefaultValueSql("GETDATE()");
        }
    }
}