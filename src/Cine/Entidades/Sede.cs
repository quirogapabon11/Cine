
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Cine.Entidades
{
    [Table("Sede")]
    public class Sede
    {
        [Key]
        [Required]
        public Guid Id { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Ciudad { get; set; }
        public List<Pelicula> Peliculas { get; set; }
        public List<Sala> Salas { get; set; }
        public List<Ciudad> Ciudades { get; set; }
        public List<Proyeccion> Proyecciones { get; set; }
        public void AgregarPelicula(Pelicula unaPelicula)
        {
            this.Peliculas.Add(unaPelicula);
        }

        public void AgregarSala(Sala unaSala)
        {
            this.Salas.Add(unaSala);
        }

        public void AgregarCiudad(Ciudad unaCiudad)
        {
            this.Ciudades.Add(unaCiudad);
        }
        public void AgregarProyeccion(Proyeccion unaProyeccion)
        {
            this.Proyecciones.Add(unaProyeccion);
        }

        public void Actualizar(string ciudad, string direccion, string nombre)
        {
            this.Ciudad = ciudad;
            this.Direccion = direccion;
            this.Nombre = nombre;
        }

        public void RemoveProyeccion(Proyeccion unaProyeccion)
        {
            this.Proyecciones.Remove(unaProyeccion);
        }

        public Sede(string nombre, string direccion, string ciudad)
        {
            this.Nombre = nombre;
            this.Direccion = direccion;
            this.Ciudad = ciudad;
            this.Peliculas = new List<Pelicula>();
            this.Salas = new List<Sala>();
            this.Proyecciones = new List<Proyeccion>();
            this.Ciudades = new List<Ciudad>();
        }

        public Sede()
        {
            this.Peliculas = new List<Pelicula>();
            this.Salas = new List<Sala>();
            this.Proyecciones = new List<Proyeccion>();
            this.Ciudades = new List<Ciudad>();
        }
    }
}