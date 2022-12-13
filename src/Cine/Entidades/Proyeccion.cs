
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Cine.Entidades
{
    [Table("Proyeccion")]
    public class Proyeccion
    {
        [Key]
        [Required]
        public Guid Id { get; protected set; }
        public string Pelicula { get; set; }
        public Guid IdSala { get; set; }
        public Guid IdCine { get; set; }
        public string Formato { get; set; }
        public DateTime Horario { get; set; }
        public Proyeccion(string pelicula, Guid idSala, Guid idCine, string formato, DateTime horario)
        {
            this.Pelicula = pelicula;
            this.IdSala = idSala;
            this.IdCine = idCine;
            this.Formato = formato;
            this.Horario = horario;
        }

        public void Actualizar(string pelicula, Guid idSala, Guid idCine, string formato, DateTime horario)
        {
            this.Pelicula = pelicula;
            this.IdSala = idSala;
            this.IdCine = idCine;
            this.Formato = formato;
            this.Horario = horario;
        }
    }
}