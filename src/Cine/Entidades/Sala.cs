
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Cine.Entidades
{
    [Table("Sala")]
    public class Sala
    {
        [Key]
        [Required]
        public Guid Id { get; protected set; }
        public int Asientos { get; set; }
        public List<Reserva> Reservas { get; set; }
        public List<Proyeccion> Proyecciones { get; set; }


        public void AgregarReserva(Reserva unaReserva)
        {
            this.Reservas.Add(unaReserva);
        }

        public void AgregarProyeccion(Proyeccion unaProyeccion)
        {
            this.Proyecciones.Add(unaProyeccion);
        }

        public void DardeBajaProyeccion(Proyeccion unaProyeccion)
        {
            this.Proyecciones.Remove(unaProyeccion);
        }

        public Sala(int asientos)
        {
            this.Asientos = asientos;
            this.Reservas = new List<Reserva>();
            this.Proyecciones = new List<Proyeccion>();
        }

        public void Actualizar(int asientos)
        {
            this.Asientos = asientos;
        }
    }
}