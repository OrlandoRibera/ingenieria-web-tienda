using Microsoft.EntityFrameworkCore;
using Tienda.Soporte.Domain.Model.Soporte;
using Tienda.Soporte.Infraestructura.EntityConfiguration;

namespace Tienda.Soporte.Infraestructura.Persistence
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Cita> Cita { get; private set; }
        public DbSet<CitaTecnico> CitaTecnico { get; private set; }
        public DbSet<Cliente> Cliente { get; private set; }
        public DbSet<FormTrabajo> FormTrabajo { get; private set; }
        public DbSet<Soporte.Domain.Model.Soporte.Soporte> Soporte { get; private set; }
        public DbSet<Tecnico> Tecnico { get; private set; }
        public DbSet<Producto> Producto { get; private set; }
        public DbSet<SoporteProducto> SoporteProducto { get; private set; }
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new CitaEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new CitaTecnicoEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new ClienteEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new FormTrabajoEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new SoporteEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new SoporteProductoTypeConfiguration());
            modelBuilder.ApplyConfiguration(new TecnicoEntityTypeConfiguration());
        }
    }
}
