using HJMH.Tarifarios.Shared.Entities;
using Microsoft.EntityFrameworkCore;

namespace HJMH.Tarifarios.Backend.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<ClasificacionUnicaProcedimientos> CUPS { get; set; }
    }
}