using LocalShared.Entities.Auditoria;
using LocalShared.Entities.Dispositivos;
using LocalShared.Entities.Elementos;
using LocalShared.Entities.Eventos;
using LocalShared.Entities.Medicion;
using LocalShared.Entities.Sistemas;
using LocalShared.Entities.Usuarios;
using Microsoft.EntityFrameworkCore;
using System.Text.RegularExpressions;
using System.Xml.Linq;

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
        public DbSet<ClsMPropiedadSistema> PropiedadesSistema { get; set; }
        public DbSet<ClsMSistema> Sistema { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<ClsMAsignacionMedio>(entity =>
            {
                entity.Property(e => e.IdAsignacionMedio).ValueGeneratedNever();

                entity.HasOne(d => d.IdMedioNavigation).WithMany(p => p.AsignacionMedios)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AsignacionMedio_Medio");

                entity.HasOne(d => d.IdTipoElementoNavigation).WithMany(p => p.AsignacionMedios)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AsignacionMedio_TipoElemento");
            });

            modelBuilder.Entity<ClsMAsignacionSistema>(entity =>
            {
                entity.Property(e => e.IdAsignacionSistema).ValueGeneratedNever();

                entity.HasOne(d => d.IdSistemaNavigation).WithMany(p => p.AsignacionSistemas)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AsignacionSistema_Sistema");

                entity.HasOne(d => d.IdUpaNavigation).WithMany(p => p.AsignacionSistemas)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AsignacionSistema_Upa");
            });

            modelBuilder.Entity<ClsMAuditoria>(entity =>
            {
                entity.Property(e => e.IdAuditoria).ValueGeneratedNever();

                entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.Auditoria)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Auditoria_Usuarios");
            });

            modelBuilder.Entity<ClsMCantidadElemento>(entity =>
            {
                entity.Property(e => e.IdCantidadElemento).ValueGeneratedNever();

                entity.HasOne(d => d.IdAsignacionSistemaNavigation).WithMany(p => p.CantidadElementos)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CantidadElemento_AsignacionSistema");

                entity.HasOne(d => d.IdElementoNavigation).WithMany(p => p.CantidadElementos)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CantidadElemento_Elementos");

                entity.HasOne(d => d.IdUnidadMedidaNavigation).WithMany(p => p.CantidadElementos)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CantidadElemento_UnidadMedida");
            });

            modelBuilder.Entity<ClsMDispositivo>(entity =>
            {
                entity.HasIndex(e => e.Sn, "IX_Dispositivo_SN")
                    .IsUnique()
                    .HasFilter("([SN] IS NOT NULL)");

                entity.Property(e => e.IdDispositivo).ValueGeneratedNever();

                entity.HasOne(d => d.IdAsignacionSistemaNavigation).WithMany(p => p.Dispositivos).HasConstraintName("FK_Dispositivo_AsignacionSistema_AsignacionSistemaId");

                entity.HasOne(d => d.IdMarcaNavigation).WithMany(p => p.Dispositivos)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Dispositivo_Marca_MarcaId");

                entity.HasOne(d => d.IdTipoDispositivoNavigation).WithMany(p => p.Dispositivos).HasConstraintName("FK_Dispositivo_TipoDispositivo_TipoDispositivoId");
            });

            modelBuilder.Entity<ClsMElemento>(entity =>
            {
                entity.Property(e => e.IdElemento).ValueGeneratedNever();

                entity.HasOne(d => d.IdTipoElementoNavigation).WithMany(p => p.Elementos).OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<ClsMEstadosDispositivo>(entity =>
            {
                entity.Property(e => e.IdEstadoDispositivo).ValueGeneratedNever();

                entity.HasOne(d => d.IdTipoDispositivoNavigation).WithMany(p => p.EstadosDispositivos)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TipoDispositivo_EstadoDispositivos");
            });

            modelBuilder.Entity<ClsMEvento>(entity =>
            {
                entity.Property(e => e.IdEvento).ValueGeneratedNever();

                entity.HasOne(d => d.IdAsignacionSistemaNavigation).WithMany(p => p.Eventos)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Evento_AsignacionSistema");

                entity.HasOne(d => d.IdAtributoSistemaNavigation).WithMany(p => p.Eventos)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Evento_AtributoSistema");

                entity.HasOne(d => d.IdElementoNavigation).WithMany(p => p.Eventos)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Evento_Elementos");

                entity.HasOne(d => d.IdTipoEventoNavigation).WithMany(p => p.Eventos).HasConstraintName("FK_Evento_TipoEvento");

                entity.HasOne(d => d.IdUnidadMedidaNavigation).WithMany(p => p.Eventos)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Evento_UnidadMedida");
            });

            modelBuilder.Entity<ClsMImpacto>(entity =>
            {
                entity.Property(e => e.IdImpacto).ValueGeneratedNever();
            });

            modelBuilder.Entity<ClsMLogsEstado>(entity =>
            {
                entity.Property(e => e.IdLogsEstados).ValueGeneratedNever();

                entity.HasOne(d => d.IdDispositivoNavigation).WithMany(p => p.LogsEstados)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LogsEstado_Dispositivo_ClsMDispositivoIdDispisitivo");

                entity.HasOne(d => d.IdEstadoDispositivoNavigation).WithMany(p => p.LogsEstados)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LogsEstados_EstadoDispositivos");
            });

            modelBuilder.Entity<ClsMMarca>(entity =>
            {
                entity.Property(e => e.IdMarca).ValueGeneratedNever();
            });

            modelBuilder.Entity<ClsMMedicion>(entity =>
            {
                entity.Property(e => e.IdMedicion).ValueGeneratedNever();

                entity.HasOne(d => d.IdDispositivoNavigation).WithMany(p => p.Medicions).HasConstraintName("FK_Medicion_Dispositivo_DispositivoId");

                entity.HasOne(d => d.IdUnidadMedidaNavigation).WithMany(p => p.Medicions).HasConstraintName("FK_Medicion_UnidadMedida");
            });

            modelBuilder.Entity<ClsMMedio>(entity =>
            {
                entity.Property(e => e.IdMedio).ValueGeneratedNever();
            });

            modelBuilder.Entity<ClsMPropiedadSistema>(entity =>
            {
                entity.Property(e => e.IdPropiedadSistema).ValueGeneratedNever();

                entity.HasOne(d => d.IdAsignacionMedioNavigation).WithMany(p => p.PropiedadSistemas)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PropiedadSistema_AsignacionMedio");

                entity.HasOne(d => d.IdAsignacionSistemaNavigation).WithMany(p => p.PropiedadSistemas)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PropiedadSistema_AsignacionSistema");

                entity.HasOne(d => d.IdUnidadMedidaNavigation).WithMany(p => p.PropiedadSistemas)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PropiedadSistema_UnidadMedida");
            });

            modelBuilder.Entity<ClsMPuntoOptimo>(entity =>
            {
                entity.Property(e => e.IdPuntoOptimo).ValueGeneratedNever();

                entity.HasOne(d => d.IdDispositivoNavigation).WithMany(p => p.PuntoOptimos)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PuntoOptimo_Dispositivos");
            });

            modelBuilder.Entity<ClsMSesionUsuario>(entity =>
            {
                entity.HasKey(e => e.IdSesion).HasName("PK__SesionUs__22EC535B9954A399");

                entity.Property(e => e.IdSesion).ValueGeneratedNever();
                entity.Property(e => e.FechaInicio).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.SesionUsuarios)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_SesionUsuario_Usuario");
            });

            modelBuilder.Entity<ClsMSistema>(entity =>
            {
                entity.HasIndex(e => e.Nombre, "IX_Sistema_Nombre")
                    .IsUnique()
                    .HasFilter("([Nombre] IS NOT NULL)");

                entity.Property(e => e.IdSistema).ValueGeneratedNever();
            });

            modelBuilder.Entity<ClsMTipoDispositivo>(entity =>
            {
                entity.Property(e => e.IdTipoDispositivo).ValueGeneratedNever();
            });

            modelBuilder.Entity<ClsMTipoElemento>(entity =>
            {
                entity.Property(e => e.IdTipoElemento).ValueGeneratedNever();
            });

            modelBuilder.Entity<ClsMTipoEvento>(entity =>
            {
                entity.Property(e => e.IdTipoEvento).ValueGeneratedNever();

                entity.HasOne(d => d.IdImpactoNavigation).WithMany(p => p.TipoEventos)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TipoEvento_Impacto");
            });

            modelBuilder.Entity<ClsMTipoMedicion>(entity =>
            {
                entity.Property(e => e.IdTipoMedicion).ValueGeneratedNever();
            });

            modelBuilder.Entity<ClsMUnidadMedida>(entity =>
            {
                entity.HasIndex(e => e.Nombre, "IX_UnidadMedida_Nombre")
                    .IsUnique()
                    .HasFilter("([Nombre] IS NOT NULL)");

                entity.Property(e => e.IdUnidadMedida).ValueGeneratedNever();

                entity.HasOne(d => d.IdTipoMedicionNavigation).WithMany(p => p.UnidadMedida)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UnidadMedida_TipoMedicion");
            });

            modelBuilder.Entity<ClsMUpa>(entity =>
            {
                entity.Property(e => e.IdUpa).ValueGeneratedNever();
            });

            modelBuilder.Entity<ClsMUsuario>(entity =>
            {
                entity.HasKey(e => e.IdUsuario).HasName("PK__Usuario__5B65BF972F19A844");

                entity.Property(e => e.IdUsuario).ValueGeneratedNever();
                entity.Property(e => e.FechaRegistro).HasDefaultValueSql("(getdate())");
            });
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
