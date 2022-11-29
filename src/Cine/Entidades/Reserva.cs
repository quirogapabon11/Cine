
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Cine.Entidades
{
    [Table("Reserva")]
    public class Reserva
    {
        [Key]
        [Required]
        public Guid Id { get; protected set; }
        public int Nro { get; set; }
        public int NroAsiento { get; set; }
        public bool Estado { get; set; } = true;
        public int NroSala { get; set; }
        public string NombreSede { get; set; }
        public Proyeccion Proyeccion { get; set; }
        public List<Pago> Pagos { get; set; }

        public void AgregarPago(Pago unPago)
        {
            this.Pagos.Add(unPago);
        }

        public Reserva(int nro, int nroAsiento, bool estado, int nroSala, string nombreSede, Proyeccion proyeccion)
        {
            this.Nro = nro;
            this.NroAsiento = nroAsiento;
            this.Estado = estado;
            this.NroSala = nroSala;
            this.NombreSede = nombreSede;
            this.Proyeccion = proyeccion;
            this.Pagos = new List<Pago>();

        }
        public Reserva()
        {

        }

        public void Actualizar(int nro, int nroAsiento, bool estado, int nroSala, string nombreSede)
        {
            this.Nro = nro;
            this.NroAsiento = nroAsiento;
            this.Estado = estado;
            this.NroSala = nroSala;
            this.NombreSede = nombreSede;
        }
    }
}