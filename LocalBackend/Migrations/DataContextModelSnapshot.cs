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

            modelBuilder.Entity("LocalShared.Entities.Dispositivos.ClsMDispositivos", b =>
                {
                    b.Property<Guid>("IdDispisitivo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("IdAsignacionSistema")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdMarca")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdTipoDispositivo")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("SN")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("IdDispisitivo");

                    b.HasIndex("SN")
                        .IsUnique()
                        .HasFilter("[SN] IS NOT NULL");

                    b.ToTable("Dispositivos");
                });

            modelBuilder.Entity("LocalShared.Entities.Dispositivos.ClsMEstadosDispositivos", b =>
                {
                    b.Property<Guid>("IdEstadoDispositivo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdTipoDispositivo")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("IdEstadoDispositivo");

                    b.HasIndex("Nombre")
                        .IsUnique();

                    b.ToTable("EstadosDispositivos");
                });

            modelBuilder.Entity("LocalShared.Entities.Dispositivos.ClsMLogsEstados", b =>
                {
                    b.Property<Guid>("IdLogsEstados")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdDispositivo")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdEstadoDsipositivo")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("MyProperty")
                        .HasColumnType("datetime2");

                    b.HasKey("IdLogsEstados");

                    b.ToTable("LogsEstados");
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

                    b.Property<Guid>("IdDispositivo")
                        .HasColumnType("uniqueidentifier");

                    b.Property<float>("ValorMaximo")
                        .HasColumnType("real");

                    b.Property<float>("ValorMinimo")
                        .HasColumnType("real");

                    b.Property<float>("ValorOptimo")
                        .HasColumnType("real");

                    b.HasKey("IdPuntoOPtimo");

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

                    b.ToTable("TipoDispositivos");
                });

            modelBuilder.Entity("LocalShared.Entities.Elementos.ClsMCantidadElementos", b =>
                {
                    b.Property<Guid>("IdCatidadElemento")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<float>("Cantidad")
                        .HasColumnType("real");

                    b.Property<Guid>("IdAsignacionSistema")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdElemento")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdUnidadMedida")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("IdCatidadElemento");

                    b.ToTable("CantidadElementos");
                });

            modelBuilder.Entity("LocalShared.Entities.Elementos.ClsMElementos", b =>
                {
                    b.Property<Guid>("IdElemento")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Estado")
                        .HasColumnType("bit");

                    b.Property<Guid>("IdTipoElemento")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("IdElemento");

                    b.HasIndex("Nombre")
                        .IsUnique();

                    b.ToTable("Elementos");
                });

            modelBuilder.Entity("LocalShared.Entities.Elementos.ClsMTipoElementos", b =>
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

                    b.ToTable("TipoElementos");
                });

            modelBuilder.Entity("LocalShared.Entities.Eventos.ClsMEvento", b =>
                {
                    b.Property<Guid>("IdEvento")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<float>("Cantidad")
                        .HasColumnType("real");

                    b.Property<DateTime>("FechaEvento")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("IdAsignacionSitema")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdAtributoSistema")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdElemento")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdTipoEvento")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdUnidadMedida")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("IdEvento");

                    b.ToTable("Eventos");
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

                    b.ToTable("Impactos");
                });

            modelBuilder.Entity("LocalShared.Entities.Eventos.ClsMTipoEvento", b =>
                {
                    b.Property<Guid>("IdTipoEvento")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdImpacto")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("IdTipoEvento");

                    b.HasIndex("Nombre")
                        .IsUnique();

                    b.ToTable("TipoEventos");
                });

            modelBuilder.Entity("LocalShared.Entities.Medicion.ClsMMedicion", b =>
                {
                    b.Property<Guid>("IdMedicion")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("IdDispositivos")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdUnidadMedida")
                        .HasColumnType("uniqueidentifier");

                    b.Property<float>("valor")
                        .HasColumnType("real");

                    b.HasKey("IdMedicion");

                    b.ToTable("Mediciones");
                });

            modelBuilder.Entity("LocalShared.Entities.Medicion.ClsMTipoMedicion", b =>
                {
                    b.Property<Guid>("IdTipoMedicion")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("IdTipoMedicion");

                    b.HasIndex("Nombre")
                        .IsUnique()
                        .HasFilter("[Nombre] IS NOT NULL");

                    b.ToTable("TipoMedicion");
                });

            modelBuilder.Entity("LocalShared.Entities.Medicion.ClsMUnidadMedida", b =>
                {
                    b.Property<Guid>("IdUnidadMedida")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Simbolo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("TipoMedicion")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("IdUnidadMedida");

                    b.HasIndex("Nombre")
                        .IsUnique();

                    b.ToTable("UnidadMedida");
                });

            modelBuilder.Entity("LocalShared.Entities.Sistemas.ClsMAsignacionMedios", b =>
                {
                    b.Property<Guid>("IdAsignacionMedio")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdMedio")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdTipoElemento")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("IdAsignacionMedio");

                    b.ToTable("AsignacionMedios");
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

                    b.Property<Guid>("IdSistema")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdUpa")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("IdAsignacionSistema");

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

                    b.Property<int>("CantidadAtributo")
                        .HasColumnType("int");

                    b.Property<Guid>("IdAsignacionSistema")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdTipoAtributo")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdUnidadMedida")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<float>("Valor")
                        .HasColumnType("real");

                    b.HasKey("IdPropiedadSistema");

                    b.ToTable("PropiedadesSistema");
                });

            modelBuilder.Entity("LocalShared.Entities.Sistemas.ClsMSistema", b =>
                {
                    b.Property<Guid>("IdSistema")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("IdSistema");

                    b.HasIndex("Nombre")
                        .IsUnique()
                        .HasFilter("[Nombre] IS NOT NULL");

                    b.ToTable("Sistemas");
                });
#pragma warning restore 612, 618
        }
    }
}
