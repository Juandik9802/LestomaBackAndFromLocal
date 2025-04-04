﻿// <auto-generated />
using System;
using LocalBackend.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LocalBackend.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("LocalShared.Entities.Auditoria.ClsMAuditoria", b =>
                {
                    b.Property<Guid>("IdAuditoria")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Accion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("IdUsuario")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Tabla")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdAuditoria");

                    b.HasIndex("Fecha")
                        .IsUnique();

                    b.ToTable("Auditoria");
                });

            modelBuilder.Entity("LocalShared.Entities.Dispositivos.ClsMDispositivo", b =>
                {
                    b.Property<Guid>("IdDispositivo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("AsignacionSistemaId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("MarcaId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("SN")
                        .HasColumnType("nvarchar(450)");

                    b.Property<Guid?>("TipoDispositivoId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("IdDispositivo");

                    b.HasIndex("AsignacionSistemaId");

                    b.HasIndex("MarcaId");

                    b.HasIndex("SN")
                        .IsUnique()
                        .HasFilter("[SN] IS NOT NULL");

                    b.HasIndex("TipoDispositivoId");

                    b.ToTable("Dispositivo");
                });

            modelBuilder.Entity("LocalShared.Entities.Dispositivos.ClsMEstadosDispositivo", b =>
                {
                    b.Property<Guid>("IdEstadoDispositivo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("IdEstadoDispositivo");

                    b.HasIndex("Nombre")
                        .IsUnique();

                    b.ToTable("EstadosDispositivo");
                });

            modelBuilder.Entity("LocalShared.Entities.Dispositivos.ClsMLogsEstado", b =>
                {
                    b.Property<Guid>("IdLogsEstado")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("DispositivoId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("EstadoDipositivoId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.HasKey("IdLogsEstado");

                    b.HasIndex("DispositivoId");

                    b.HasIndex("EstadoDipositivoId");

                    b.ToTable("LogsEstado");
                });

            modelBuilder.Entity("LocalShared.Entities.Dispositivos.ClsMMarca", b =>
                {
                    b.Property<Guid>("IdMarca")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("IdMarca");

                    b.HasIndex("Nombre")
                        .IsUnique();

                    b.ToTable("Marca");
                });

            modelBuilder.Entity("LocalShared.Entities.Dispositivos.ClsMPuntoOptimo", b =>
                {
                    b.Property<Guid>("IdPuntoOPtimo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("DispositivoId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<float>("ValorMaximo")
                        .HasColumnType("real");

                    b.Property<float>("ValorMinimo")
                        .HasColumnType("real");

                    b.Property<float>("ValorOptimo")
                        .HasColumnType("real");

                    b.HasKey("IdPuntoOPtimo");

                    b.HasIndex("DispositivoId");

                    b.ToTable("PuntoOptimo");
                });

            modelBuilder.Entity("LocalShared.Entities.Dispositivos.ClsMTipoDispositivo", b =>
                {
                    b.Property<Guid>("IdTipoDispositivo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("IdTipoDispositivo");

                    b.HasIndex("Nombre")
                        .IsUnique();

                    b.ToTable("TipoDispositivo");
                });

            modelBuilder.Entity("LocalShared.Entities.Elementos.ClsMCantidadElemento", b =>
                {
                    b.Property<Guid>("IdCatidadElemento")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("AsignacionSistemaId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<float>("Cantidad")
                        .HasColumnType("real");

                    b.Property<Guid?>("ElementoId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("UnidadMedidaId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("IdCatidadElemento");

                    b.HasIndex("AsignacionSistemaId");

                    b.HasIndex("ElementoId");

                    b.HasIndex("UnidadMedidaId");

                    b.ToTable("CantidadElemento");
                });

            modelBuilder.Entity("LocalShared.Entities.Elementos.ClsMElemento", b =>
                {
                    b.Property<Guid>("IdElemento")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Estado")
                        .HasColumnType("bit");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<Guid?>("TipoElementoId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("IdElemento");

                    b.HasIndex("Nombre")
                        .IsUnique();

                    b.HasIndex("TipoElementoId");

                    b.ToTable("Elemento");
                });

            modelBuilder.Entity("LocalShared.Entities.Elementos.ClsMTipoElemento", b =>
                {
                    b.Property<Guid>("IdTipoElemento")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("IdTipoElemento");

                    b.HasIndex("Nombre")
                        .IsUnique();

                    b.ToTable("TipoElemento");
                });

            modelBuilder.Entity("LocalShared.Entities.Eventos.ClsMEvento", b =>
                {
                    b.Property<Guid>("IdEvento")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("AsignacionSistemaId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<float>("Cantidad")
                        .HasColumnType("real");

                    b.Property<Guid?>("ElementoId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("FechaEvento")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("PropiedadesSistemaId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("TipoEventoId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("UnidadMedidaId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("IdEvento");

                    b.HasIndex("AsignacionSistemaId");

                    b.HasIndex("ElementoId");

                    b.HasIndex("PropiedadesSistemaId");

                    b.HasIndex("TipoEventoId");

                    b.HasIndex("UnidadMedidaId");

                    b.ToTable("Evento");
                });

            modelBuilder.Entity("LocalShared.Entities.Eventos.ClsMImpacto", b =>
                {
                    b.Property<Guid>("IdImpacto")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("IdImpacto");

                    b.HasIndex("Nombre")
                        .IsUnique();

                    b.ToTable("Impacto");
                });

            modelBuilder.Entity("LocalShared.Entities.Eventos.ClsMTipoEvento", b =>
                {
                    b.Property<Guid>("IdTipoEvento")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ImpactoId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("IdTipoEvento");

                    b.HasIndex("ImpactoId");

                    b.HasIndex("Nombre")
                        .IsUnique();

                    b.ToTable("TipoEvento");
                });

            modelBuilder.Entity("LocalShared.Entities.Medicion.ClsMMedicion", b =>
                {
                    b.Property<Guid>("IdMedicion")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("DispositivoId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("UnidadMedidaId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<float>("valor")
                        .HasColumnType("real");

                    b.HasKey("IdMedicion");

                    b.HasIndex("DispositivoId");

                    b.HasIndex("UnidadMedidaId");

                    b.ToTable("Medicion");
                });

            modelBuilder.Entity("LocalShared.Entities.Medicion.ClsMTipoMedicion", b =>
                {
                    b.Property<Guid>("IdTipoMedicion")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("IdTipoMedicion");

                    b.HasIndex("Nombre")
                        .IsUnique();

                    b.ToTable("TipoMedicion");
                });

            modelBuilder.Entity("LocalShared.Entities.Medicion.ClsMUnidadMedida", b =>
                {
                    b.Property<Guid>("IdUnidadMedida")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Simbolo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("TipoMedicionId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("IdUnidadMedida");

                    b.HasIndex("Nombre")
                        .IsUnique()
                        .HasFilter("[Nombre] IS NOT NULL");

                    b.HasIndex("TipoMedicionId");

                    b.ToTable("UnidadMedida");
                });

            modelBuilder.Entity("LocalShared.Entities.Sistemas.ClsMAsignacionMedio", b =>
                {
                    b.Property<Guid>("IdAsignacionMedio")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("MedioId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("TipoElementoId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("IdAsignacionMedio");

                    b.HasIndex("MedioId");

                    b.HasIndex("TipoElementoId");

                    b.ToTable("AsignacionMedio");
                });

            modelBuilder.Entity("LocalShared.Entities.Sistemas.ClsMAsignacionSistema", b =>
                {
                    b.Property<Guid>("IdAsignacionSistema")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Estado")
                        .HasColumnType("bit");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("IdUpa")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("SistemaId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("IdAsignacionSistema");

                    b.HasIndex("SistemaId");

                    b.ToTable("AsignacionSistema");
                });

            modelBuilder.Entity("LocalShared.Entities.Sistemas.ClsMMedio", b =>
                {
                    b.Property<Guid>("IdMedio")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("IdMedio");

                    b.HasIndex("Nombre")
                        .IsUnique();

                    b.ToTable("Medio");
                });

            modelBuilder.Entity("LocalShared.Entities.Sistemas.ClsMPropiedadesSistema", b =>
                {
                    b.Property<Guid>("IdPropiedadSistema")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("AsignacionSistemaId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("CantidadAtributo")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<Guid>("UnidadMedidaId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<float>("Valor")
                        .HasColumnType("real");

                    b.HasKey("IdPropiedadSistema");

                    b.HasIndex("AsignacionSistemaId");

                    b.HasIndex("UnidadMedidaId");

                    b.ToTable("PropiedadesSistema");
                });

            modelBuilder.Entity("LocalShared.Entities.Sistemas.ClsMSistema", b =>
                {
                    b.Property<Guid>("IdSistema")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("IdSistema");

                    b.HasIndex("Nombre")
                        .IsUnique();

                    b.ToTable("Sistema");
                });

            modelBuilder.Entity("LocalShared.Entities.Dispositivos.ClsMDispositivo", b =>
                {
                    b.HasOne("LocalShared.Entities.Sistemas.ClsMAsignacionSistema", "AsignacionSistema")
                        .WithMany()
                        .HasForeignKey("AsignacionSistemaId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("LocalShared.Entities.Dispositivos.ClsMMarca", "Marca")
                        .WithMany("mDispositivos")
                        .HasForeignKey("MarcaId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("LocalShared.Entities.Dispositivos.ClsMTipoDispositivo", "TipoDispositivo")
                        .WithMany("mDispositivos")
                        .HasForeignKey("TipoDispositivoId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("AsignacionSistema");

                    b.Navigation("Marca");

                    b.Navigation("TipoDispositivo");
                });

            modelBuilder.Entity("LocalShared.Entities.Dispositivos.ClsMLogsEstado", b =>
                {
                    b.HasOne("LocalShared.Entities.Dispositivos.ClsMDispositivo", "Dispositivo")
                        .WithMany("LogsEstados")
                        .HasForeignKey("DispositivoId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("LocalShared.Entities.Dispositivos.ClsMEstadosDispositivo", "EstadoDipositivo")
                        .WithMany("LogsEstados")
                        .HasForeignKey("EstadoDipositivoId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Dispositivo");

                    b.Navigation("EstadoDipositivo");
                });

            modelBuilder.Entity("LocalShared.Entities.Dispositivos.ClsMPuntoOptimo", b =>
                {
                    b.HasOne("LocalShared.Entities.Dispositivos.ClsMDispositivo", "Dispositivo")
                        .WithMany("puntoOptimos")
                        .HasForeignKey("DispositivoId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("Dispositivo");
                });

            modelBuilder.Entity("LocalShared.Entities.Elementos.ClsMCantidadElemento", b =>
                {
                    b.HasOne("LocalShared.Entities.Sistemas.ClsMAsignacionSistema", "AsignacionSistema")
                        .WithMany()
                        .HasForeignKey("AsignacionSistemaId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("LocalShared.Entities.Elementos.ClsMElemento", "Elemento")
                        .WithMany("CantidadElementos")
                        .HasForeignKey("ElementoId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("LocalShared.Entities.Medicion.ClsMUnidadMedida", "UnidadMedida")
                        .WithMany()
                        .HasForeignKey("UnidadMedidaId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("AsignacionSistema");

                    b.Navigation("Elemento");

                    b.Navigation("UnidadMedida");
                });

            modelBuilder.Entity("LocalShared.Entities.Elementos.ClsMElemento", b =>
                {
                    b.HasOne("LocalShared.Entities.Elementos.ClsMTipoElemento", "TipoElemento")
                        .WithMany("Elementos")
                        .HasForeignKey("TipoElementoId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("TipoElemento");
                });

            modelBuilder.Entity("LocalShared.Entities.Eventos.ClsMEvento", b =>
                {
                    b.HasOne("LocalShared.Entities.Sistemas.ClsMAsignacionSistema", "AsignacionSistema")
                        .WithMany()
                        .HasForeignKey("AsignacionSistemaId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("LocalShared.Entities.Elementos.ClsMElemento", "Elemento")
                        .WithMany()
                        .HasForeignKey("ElementoId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("LocalShared.Entities.Sistemas.ClsMPropiedadesSistema", "PropiedadesSistema")
                        .WithMany()
                        .HasForeignKey("PropiedadesSistemaId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("LocalShared.Entities.Eventos.ClsMTipoEvento", "TipoEvento")
                        .WithMany("eventos")
                        .HasForeignKey("TipoEventoId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("LocalShared.Entities.Medicion.ClsMUnidadMedida", "UnidadMedida")
                        .WithMany()
                        .HasForeignKey("UnidadMedidaId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("AsignacionSistema");

                    b.Navigation("Elemento");

                    b.Navigation("PropiedadesSistema");

                    b.Navigation("TipoEvento");

                    b.Navigation("UnidadMedida");
                });

            modelBuilder.Entity("LocalShared.Entities.Eventos.ClsMTipoEvento", b =>
                {
                    b.HasOne("LocalShared.Entities.Eventos.ClsMImpacto", "Impacto")
                        .WithMany("tipoEventos")
                        .HasForeignKey("ImpactoId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Impacto");
                });

            modelBuilder.Entity("LocalShared.Entities.Medicion.ClsMMedicion", b =>
                {
                    b.HasOne("LocalShared.Entities.Dispositivos.ClsMDispositivo", "Dispositivo")
                        .WithMany()
                        .HasForeignKey("DispositivoId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("LocalShared.Entities.Medicion.ClsMUnidadMedida", "UnidadMedida")
                        .WithMany("MMediciones")
                        .HasForeignKey("UnidadMedidaId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("Dispositivo");

                    b.Navigation("UnidadMedida");
                });

            modelBuilder.Entity("LocalShared.Entities.Medicion.ClsMUnidadMedida", b =>
                {
                    b.HasOne("LocalShared.Entities.Medicion.ClsMTipoMedicion", "TipoMedicion")
                        .WithMany("unidadMedidas")
                        .HasForeignKey("TipoMedicionId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("TipoMedicion");
                });

            modelBuilder.Entity("LocalShared.Entities.Sistemas.ClsMAsignacionMedio", b =>
                {
                    b.HasOne("LocalShared.Entities.Sistemas.ClsMMedio", "Medio")
                        .WithMany("AsignacionMedios")
                        .HasForeignKey("MedioId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("LocalShared.Entities.Elementos.ClsMTipoElemento", "TipoElemento")
                        .WithMany()
                        .HasForeignKey("TipoElementoId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Medio");

                    b.Navigation("TipoElemento");
                });

            modelBuilder.Entity("LocalShared.Entities.Sistemas.ClsMAsignacionSistema", b =>
                {
                    b.HasOne("LocalShared.Entities.Sistemas.ClsMSistema", "Sistema")
                        .WithMany("AsignacionSistemas")
                        .HasForeignKey("SistemaId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("Sistema");
                });

            modelBuilder.Entity("LocalShared.Entities.Sistemas.ClsMPropiedadesSistema", b =>
                {
                    b.HasOne("LocalShared.Entities.Sistemas.ClsMAsignacionSistema", "AsignacionSistema")
                        .WithMany()
                        .HasForeignKey("AsignacionSistemaId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("LocalShared.Entities.Medicion.ClsMUnidadMedida", "UnidadMedida")
                        .WithMany()
                        .HasForeignKey("UnidadMedidaId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("AsignacionSistema");

                    b.Navigation("UnidadMedida");
                });

            modelBuilder.Entity("LocalShared.Entities.Dispositivos.ClsMDispositivo", b =>
                {
                    b.Navigation("LogsEstados");

                    b.Navigation("puntoOptimos");
                });

            modelBuilder.Entity("LocalShared.Entities.Dispositivos.ClsMEstadosDispositivo", b =>
                {
                    b.Navigation("LogsEstados");
                });

            modelBuilder.Entity("LocalShared.Entities.Dispositivos.ClsMMarca", b =>
                {
                    b.Navigation("mDispositivos");
                });

            modelBuilder.Entity("LocalShared.Entities.Dispositivos.ClsMTipoDispositivo", b =>
                {
                    b.Navigation("mDispositivos");
                });

            modelBuilder.Entity("LocalShared.Entities.Elementos.ClsMElemento", b =>
                {
                    b.Navigation("CantidadElementos");
                });

            modelBuilder.Entity("LocalShared.Entities.Elementos.ClsMTipoElemento", b =>
                {
                    b.Navigation("Elementos");
                });

            modelBuilder.Entity("LocalShared.Entities.Eventos.ClsMImpacto", b =>
                {
                    b.Navigation("tipoEventos");
                });

            modelBuilder.Entity("LocalShared.Entities.Eventos.ClsMTipoEvento", b =>
                {
                    b.Navigation("eventos");
                });

            modelBuilder.Entity("LocalShared.Entities.Medicion.ClsMTipoMedicion", b =>
                {
                    b.Navigation("unidadMedidas");
                });

            modelBuilder.Entity("LocalShared.Entities.Medicion.ClsMUnidadMedida", b =>
                {
                    b.Navigation("MMediciones");
                });

            modelBuilder.Entity("LocalShared.Entities.Sistemas.ClsMMedio", b =>
                {
                    b.Navigation("AsignacionMedios");
                });

            modelBuilder.Entity("LocalShared.Entities.Sistemas.ClsMSistema", b =>
                {
                    b.Navigation("AsignacionSistemas");
                });
#pragma warning restore 612, 618
        }
    }
}
