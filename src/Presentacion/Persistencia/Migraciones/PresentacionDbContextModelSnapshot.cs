﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Presentacion.Persistencia;

#nullable disable

namespace Presentacion.Persistencia.Migraciones
{
    [DbContext(typeof(PresentacionDbContext))]
    partial class PresentacionDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Cine.Entidades.CadenaCine", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<Guid?>("SistemaId")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.HasIndex("SistemaId");

                    b.ToTable("CadenaCine");
                });

            modelBuilder.Entity("Cine.Entidades.Ciudad", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<int>("NroSede")
                        .HasColumnType("int");

                    b.Property<Guid?>("SedeId")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.HasIndex("SedeId");

                    b.ToTable("Ciudad");
                });

            modelBuilder.Entity("Cine.Entidades.Cupon", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Codigo")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Descuento")
                        .HasColumnType("int");

                    b.Property<Guid?>("PagoId")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.HasIndex("PagoId");

                    b.ToTable("Cupon");
                });

            modelBuilder.Entity("Cine.Entidades.Invitado", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<int>("Edad")
                        .HasColumnType("int");

                    b.Property<Guid?>("MiembroId")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.HasIndex("MiembroId");

                    b.ToTable("Invitado");
                });

            modelBuilder.Entity("Cine.Entidades.Miembro", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<Guid?>("CadenaCineId")
                        .HasColumnType("char(36)");

                    b.Property<string>("Contrasena")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("Habilitado")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<Guid?>("SistemaId")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.HasIndex("CadenaCineId");

                    b.HasIndex("SistemaId");

                    b.ToTable("Miembro");
                });

            modelBuilder.Entity("Cine.Entidades.Notificacion", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<Guid?>("PagoId")
                        .HasColumnType("char(36)");

                    b.Property<Guid?>("SistemaId")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.HasIndex("PagoId");

                    b.HasIndex("SistemaId");

                    b.ToTable("Notificacion");
                });

            modelBuilder.Entity("Cine.Entidades.Pago", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<int>("Monto")
                        .HasColumnType("int");

                    b.Property<Guid?>("ReservaId")
                        .HasColumnType("char(36)");

                    b.Property<string>("tipoPago")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("ReservaId");

                    b.ToTable("Pago");
                });

            modelBuilder.Entity("Cine.Entidades.Pelicula", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<Guid?>("AdministradorId")
                        .HasColumnType("char(36)");

                    b.Property<string>("Calidad")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<decimal>("Duracion")
                        .HasColumnType("decimal(65,30)");

                    b.Property<string>("Genero")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Idioma")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("Lanzamiento")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid?>("SedeId")
                        .HasColumnType("char(36)");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("AdministradorId");

                    b.HasIndex("SedeId");

                    b.ToTable("Pelicula");
                });

            modelBuilder.Entity("Cine.Entidades.Proyeccion", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Formato")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("Horario")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid>("IdCine")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("IdSala")
                        .HasColumnType("char(36)");

                    b.Property<string>("Pelicula")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<Guid?>("SalaId")
                        .HasColumnType("char(36)");

                    b.Property<Guid?>("SedeId")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.HasIndex("SalaId");

                    b.HasIndex("SedeId");

                    b.ToTable("Proyeccion");
                });

            modelBuilder.Entity("Cine.Entidades.Reserva", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<bool>("Estado")
                        .HasColumnType("tinyint(1)");

                    b.Property<Guid?>("MiembroId")
                        .HasColumnType("char(36)");

                    b.Property<string>("NombreSede")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Nro")
                        .HasColumnType("int");

                    b.Property<int>("NroAsiento")
                        .HasColumnType("int");

                    b.Property<int>("NroSala")
                        .HasColumnType("int");

                    b.Property<Guid>("ProyeccionId")
                        .HasColumnType("char(36)");

                    b.Property<Guid?>("SalaId")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.HasIndex("MiembroId");

                    b.HasIndex("ProyeccionId");

                    b.HasIndex("SalaId");

                    b.ToTable("Reserva");
                });

            modelBuilder.Entity("Cine.Entidades.Sala", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<int>("Asientos")
                        .HasColumnType("int");

                    b.Property<Guid?>("SedeId")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.HasIndex("SedeId");

                    b.ToTable("Sala");
                });

            modelBuilder.Entity("Cine.Entidades.Sede", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<Guid?>("AdministradorId")
                        .HasColumnType("char(36)");

                    b.Property<Guid?>("CadenaCineId")
                        .HasColumnType("char(36)");

                    b.Property<string>("Ciudad")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("AdministradorId");

                    b.HasIndex("CadenaCineId");

                    b.ToTable("Sede");
                });

            modelBuilder.Entity("Cine.Entidades.Sistema", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<Guid?>("AdministradorId")
                        .HasColumnType("char(36)");

                    b.Property<int>("Reservas")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AdministradorId");

                    b.ToTable("Sistema");
                });

            modelBuilder.Entity("Cine.Entidades.Administrador", b =>
                {
                    b.HasBaseType("Cine.Entidades.Miembro");

                    b.ToTable("Administrador");
                });

            modelBuilder.Entity("Cine.Entidades.CadenaCine", b =>
                {
                    b.HasOne("Cine.Entidades.Sistema", null)
                        .WithMany("CadenasdeCines")
                        .HasForeignKey("SistemaId");
                });

            modelBuilder.Entity("Cine.Entidades.Ciudad", b =>
                {
                    b.HasOne("Cine.Entidades.Sede", null)
                        .WithMany("Ciudades")
                        .HasForeignKey("SedeId");
                });

            modelBuilder.Entity("Cine.Entidades.Cupon", b =>
                {
                    b.HasOne("Cine.Entidades.Pago", null)
                        .WithMany("Cupones")
                        .HasForeignKey("PagoId");
                });

            modelBuilder.Entity("Cine.Entidades.Invitado", b =>
                {
                    b.HasOne("Cine.Entidades.Miembro", null)
                        .WithMany("Invitados")
                        .HasForeignKey("MiembroId");
                });

            modelBuilder.Entity("Cine.Entidades.Miembro", b =>
                {
                    b.HasOne("Cine.Entidades.CadenaCine", null)
                        .WithMany("Miembros")
                        .HasForeignKey("CadenaCineId");

                    b.HasOne("Cine.Entidades.Sistema", null)
                        .WithMany("Miembros")
                        .HasForeignKey("SistemaId");
                });

            modelBuilder.Entity("Cine.Entidades.Notificacion", b =>
                {
                    b.HasOne("Cine.Entidades.Pago", null)
                        .WithMany("Notificaciones")
                        .HasForeignKey("PagoId");

                    b.HasOne("Cine.Entidades.Sistema", null)
                        .WithMany("Notificaciones")
                        .HasForeignKey("SistemaId");
                });

            modelBuilder.Entity("Cine.Entidades.Pago", b =>
                {
                    b.HasOne("Cine.Entidades.Reserva", null)
                        .WithMany("Pagos")
                        .HasForeignKey("ReservaId");
                });

            modelBuilder.Entity("Cine.Entidades.Pelicula", b =>
                {
                    b.HasOne("Cine.Entidades.Administrador", null)
                        .WithMany("Peliculas")
                        .HasForeignKey("AdministradorId");

                    b.HasOne("Cine.Entidades.Sede", null)
                        .WithMany("Peliculas")
                        .HasForeignKey("SedeId");
                });

            modelBuilder.Entity("Cine.Entidades.Proyeccion", b =>
                {
                    b.HasOne("Cine.Entidades.Sala", null)
                        .WithMany("Proyecciones")
                        .HasForeignKey("SalaId");

                    b.HasOne("Cine.Entidades.Sede", null)
                        .WithMany("Proyecciones")
                        .HasForeignKey("SedeId");
                });

            modelBuilder.Entity("Cine.Entidades.Reserva", b =>
                {
                    b.HasOne("Cine.Entidades.Miembro", null)
                        .WithMany("Reservas")
                        .HasForeignKey("MiembroId");

                    b.HasOne("Cine.Entidades.Proyeccion", "Proyeccion")
                        .WithMany()
                        .HasForeignKey("ProyeccionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Cine.Entidades.Sala", null)
                        .WithMany("Reservas")
                        .HasForeignKey("SalaId");

                    b.Navigation("Proyeccion");
                });

            modelBuilder.Entity("Cine.Entidades.Sala", b =>
                {
                    b.HasOne("Cine.Entidades.Sede", null)
                        .WithMany("Salas")
                        .HasForeignKey("SedeId");
                });

            modelBuilder.Entity("Cine.Entidades.Sede", b =>
                {
                    b.HasOne("Cine.Entidades.Administrador", null)
                        .WithMany("Sedes")
                        .HasForeignKey("AdministradorId");

                    b.HasOne("Cine.Entidades.CadenaCine", null)
                        .WithMany("Sedes")
                        .HasForeignKey("CadenaCineId");
                });

            modelBuilder.Entity("Cine.Entidades.Sistema", b =>
                {
                    b.HasOne("Cine.Entidades.Administrador", null)
                        .WithMany("Sistemas")
                        .HasForeignKey("AdministradorId");
                });

            modelBuilder.Entity("Cine.Entidades.Administrador", b =>
                {
                    b.HasOne("Cine.Entidades.Miembro", null)
                        .WithOne()
                        .HasForeignKey("Cine.Entidades.Administrador", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Cine.Entidades.CadenaCine", b =>
                {
                    b.Navigation("Miembros");

                    b.Navigation("Sedes");
                });

            modelBuilder.Entity("Cine.Entidades.Miembro", b =>
                {
                    b.Navigation("Invitados");

                    b.Navigation("Reservas");
                });

            modelBuilder.Entity("Cine.Entidades.Pago", b =>
                {
                    b.Navigation("Cupones");

                    b.Navigation("Notificaciones");
                });

            modelBuilder.Entity("Cine.Entidades.Reserva", b =>
                {
                    b.Navigation("Pagos");
                });

            modelBuilder.Entity("Cine.Entidades.Sala", b =>
                {
                    b.Navigation("Proyecciones");

                    b.Navigation("Reservas");
                });

            modelBuilder.Entity("Cine.Entidades.Sede", b =>
                {
                    b.Navigation("Ciudades");

                    b.Navigation("Peliculas");

                    b.Navigation("Proyecciones");

                    b.Navigation("Salas");
                });

            modelBuilder.Entity("Cine.Entidades.Sistema", b =>
                {
                    b.Navigation("CadenasdeCines");

                    b.Navigation("Miembros");

                    b.Navigation("Notificaciones");
                });

            modelBuilder.Entity("Cine.Entidades.Administrador", b =>
                {
                    b.Navigation("Peliculas");

                    b.Navigation("Sedes");

                    b.Navigation("Sistemas");
                });
#pragma warning restore 612, 618
        }
    }
}
