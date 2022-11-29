
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Cine.Entidades
{
    [Table("Pelicula")]
    public class Pelicula
    {
        [Key]
        [Required]
        public Guid Id { get; protected set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public string Idioma { get; set; }
        public string Genero { get; set; }
        public DateTime Lanzamiento { get; set; }
        public string Calidad { get; set; }
        public decimal Duracion { get; set; }
        public Pelicula(string titulo, string descripcion, string idioma, string genero, DateTime lanzamiento, string calidad, decimal duracion)
        {
            this.Titulo = titulo;
            this.Descripcion = descripcion;
            this.Idioma = idioma;
            this.Genero = genero;
            this.Lanzamiento = lanzamiento;
            this.Calidad = calidad;
            this.Duracion = duracion;
        }

        public void Actualizar(string titulo, string descripcion, string idioma, string genero, DateTime lanzamiento, string calidad, decimal duracion)
        {
            this.Titulo = titulo;
            this.Descripcion = descripcion;
            this.Idioma = idioma;
            this.Genero = genero;
            this.Lanzamiento = lanzamiento;
            this.Calidad = calidad;
            this.Duracion = duracion;
        }
    }

}