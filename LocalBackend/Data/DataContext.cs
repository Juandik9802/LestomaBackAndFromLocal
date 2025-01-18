using LocalShared.Entities.Cultivo;
using Microsoft.EntityFrameworkCore;

namespace LocalBackend.Data
{
    public class DataContext : DbContext

    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<ClsMTipoCultivo> Cultivos { get; set; }
        public DbSet<ClsMPlantas> Plantas { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<LocalShared.Entities.Cultivo.ClsMPlantas>().HasIndex(x => x.PltNombre).IsUnique();
            modelBuilder.Entity<LocalShared.Entities.Cultivo.ClsMTipoCultivo>().HasIndex(x => x.TipCltNombre).IsUnique();
        }
    }
}
