using LocalShared.Entities.Auditoria;
using LocalShared.Entities.Dispositivos;
using LocalShared.Entities.Elementos;
using LocalShared.Entities.Eventos;
using LocalShared.Entities.Medicion;
using LocalShared.Entities.Sistemas;
using Microsoft.EntityFrameworkCore;

namespace LocalBackend.Data
{
    public class DataContext : DbContext

    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        //Auditoria
        public DbSet<ClsMAuditoria> Auditoria { get; set; }
        //Dispositivo
        public DbSet<ClsMDispositivo> Dispositivo { get; set; }
        public DbSet<ClsMEstadosDispositivo> EstadosDispositivo { get; set; }
        public DbSet<ClsMLogsEstado> LogsEstado { get; set; }
        public DbSet<ClsMMarca> Marca { get; set; }
        public DbSet<ClsMPuntoOptimo> PuntoOptimo { get; set; }
        public DbSet<ClsMTipoDispositivo> TipoDispositivo { get; set; }
        //Elemento
        public DbSet<ClsMCantidadElemento> CantidadElemento { get; set; }
        public DbSet<ClsMElemento> Elemento { get; set; }
        public DbSet<ClsMTipoElemento> TipoElemento { get; set; }
        //Eventos
        public DbSet<ClsMEvento> Evento { get; set; }
        public DbSet<ClsMImpacto> Impacto { get; set; }
        public DbSet<ClsMTipoEvento> TipoEvento { get; set; }
        //Medicion
        public DbSet<ClsMMedicion> Medicion { get; set; }
        public DbSet<ClsMTipoMedicion> TipoMedicion { get; set; }
        public DbSet<ClsMUnidadMedida> UnidadMedida { get; set; }
        //Sistema
        public DbSet<ClsMAsignacionMedio> AsignacionMedio { get; set; }
        public DbSet<ClsMAsignacionSistema> AsignacionSistema { get; set; }
        public DbSet<ClsMMedio> Medio { get; set; }
        public DbSet<ClsMPropiedadesSistema> PropiedadesSistema { get; set; }
        public DbSet<ClsMSistema> Sistema { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //Auditoria
            modelBuilder.Entity<LocalShared.Entities.Auditoria.ClsMAuditoria>().HasIndex(x => x.Fecha).IsUnique();
            //Dispositivo
            modelBuilder.Entity<LocalShared.Entities.Dispositivos.ClsMDispositivo>().HasIndex(x => x.SN).IsUnique();
            modelBuilder.Entity<LocalShared.Entities.Dispositivos.ClsMEstadosDispositivo>().HasIndex(x => x.Nombre).IsUnique();
            modelBuilder.Entity<LocalShared.Entities.Dispositivos.ClsMMarca>().HasIndex(x => x.Nombre).IsUnique();
            modelBuilder.Entity<LocalShared.Entities.Dispositivos.ClsMTipoDispositivo>().HasIndex(x => x.Nombre).IsUnique();
            //Elemento
            modelBuilder.Entity<LocalShared.Entities.Elementos.ClsMElemento>().HasIndex(x => x.Nombre).IsUnique();
            modelBuilder.Entity<LocalShared.Entities.Elementos.ClsMTipoElemento>().HasIndex(x => x.Nombre).IsUnique();
            //Eventos
            modelBuilder.Entity<LocalShared.Entities.Eventos.ClsMImpacto>().HasIndex(x => x.Nombre).IsUnique();
            modelBuilder.Entity<LocalShared.Entities.Eventos.ClsMTipoEvento>().HasIndex(x => x.Nombre).IsUnique();
            //Medicion
            modelBuilder.Entity<LocalShared.Entities.Medicion.ClsMTipoMedicion>().HasIndex(x => x.Nombre).IsUnique();
            modelBuilder.Entity<LocalShared.Entities.Medicion.ClsMUnidadMedida>().HasIndex(x => x.Nombre).IsUnique();
            //Sistema
            modelBuilder.Entity<LocalShared.Entities.Sistemas.ClsMSistema>().HasIndex(x => x.Nombre).IsUnique();
            modelBuilder.Entity<LocalShared.Entities.Sistemas.ClsMMedio>().HasIndex(x => x.Nombre).IsUnique();
            DisableCascadingDelete(modelBuilder);
            modelBuilder.Entity<ClsMUnidadMedida>()
                .HasMany(u => u.MMediciones)
                .WithOne(m => m.UnidadMedida)
                .HasForeignKey(m => m.UnidadMedidaId);

        }

        private void DisableCascadingDelete(ModelBuilder modelBuilder)
        {
            var relationships = modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys());
            foreach (var relationship in relationships)
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }
        }
    }
}
