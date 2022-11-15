using Dominio.Entidades;
using Microsoft.EntityFrameworkCore;

namespace Presentacion.Persistencia;

public class PresentacionDbContext : DbContext
{
    //Constructor con opciones se va usar para crear la base de datos desde codigo C#
    //SQL -> CREATE DATABASE proyecto_db;
    public PresentacionDbContext(DbContextOptions<AplicacionDbContext> opciones)
        : base(opciones)
    {

    }

    //Cada lista representa se persisten en una tabla en una base de datos relacional (MySql)
    public DbSet<Administrador> Administradores { get; set; }
    public DbSet<CadenaCine> CadenadeCines { get; set; }
    public DbSet<Ciudad> Ciudades { get; set; }
    public DbSet<Cupon> Cupones { get; set; }
    public DbSet<Invitado> Invitados { get; set; }
    public DbSet<Miembro> Miembros { get; set; }
    public DbSet<Notificacion> Notificaciones { get; set; }
    public DbSet<Pago> Pagos { get; set; }
    public DbSet<Pelicula> Peliculas { get; set; }
    public DbSet<Proyeccion> Proyecciones { get; set; }
    public DbSet<Reserva> Reservas { get; set; }
    public DbSet<Sala> Salas { get; set; }
    public DbSet<Sede> Sedes { get; set; }
    public DbSet<Usuario> Usuarios { get; set; }

}