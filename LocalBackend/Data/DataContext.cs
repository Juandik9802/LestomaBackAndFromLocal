using LocalShared.Entities.Auditoria;
using LocalShared.Entities.Dispositivos;
using LocalShared.Entities.Elementos;
using LocalShared.Entities.Eventos;
using LocalShared.Entities.Medicion;
using LocalShared.Entities.Sistemas;
using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;

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
        public DbSet<ClsMDispositivos> Dispositivos { get; set; }
        public DbSet<ClsMEstadosDispositivos> EstadosDispositivos { get; set; }
        public DbSet<ClsMLogsEstados> LogsEstados { get; set; }
        public DbSet<ClsMMarca> Marca { get; set; }
        public DbSet<ClsMPuntoOptimo> PuntoOptimo { get; set; }
        public DbSet<ClsMTipoDispositivo> TipoDispositivos{ get; set; }
        //Elemento
        public DbSet<ClsMCantidadElementos> CantidadElementos { get; set; }
        public DbSet<ClsMElementos> Elementos { get; set; }
        public DbSet<ClsMTipoElementos> TipoElementos { get; set; }
        //Eventos
        public DbSet<ClsMEvento> Eventos { get; set; }
        public DbSet<ClsMImpacto> Impactos { get; set; }
        public DbSet<ClsMTipoEvento> TipoEventos { get; set; }
        //Medicion
        public DbSet<ClsMMedicion> Mediciones { get; set; }
        public DbSet<ClsMTipoMedicion> TipoMedicion { get; set; }
        public DbSet<ClsMUnidadMedida> UnidadMedida { get; set; }
        //Sistema
        public DbSet<ClsMAsignacionMedios> AsignacionMedios { get; set; }
        public DbSet<ClsMAsignacionSistema> AsignacionSistema { get; set; }
        public DbSet<ClsMMedio> Medio { get; set; }
        public DbSet<ClsMPropiedadesSistema> PropiedadesSistema { get; set; }
        public DbSet<ClsMSistema> Sistemas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //Auditoria
            modelBuilder.Entity<LocalShared.Entities.Auditoria.ClsMAuditoria>().HasIndex(x => x.Fecha).IsUnique();    
            //Dispositivo
            modelBuilder.Entity<LocalShared.Entities.Dispositivos.ClsMDispositivos>().HasIndex(x => x.SN).IsUnique();
            modelBuilder.Entity<LocalShared.Entities.Dispositivos.ClsMEstadosDispositivos>().HasIndex(x => x.Nombre).IsUnique();
            modelBuilder.Entity<LocalShared.Entities.Dispositivos.ClsMMarca>().HasIndex(x => x.Nombre).IsUnique();
            modelBuilder.Entity<LocalShared.Entities.Dispositivos.ClsMTipoDispositivo>().HasIndex(x => x.Nombre).IsUnique();
            //Elemento
            modelBuilder.Entity<LocalShared.Entities.Elementos.ClsMElementos>().HasIndex(x => x.Nombre).IsUnique();
            modelBuilder.Entity<LocalShared.Entities.Elementos.ClsMTipoElementos>().HasIndex(x => x.Nombre).IsUnique();
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
