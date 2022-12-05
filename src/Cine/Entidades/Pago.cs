
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Cine.Entidades
{
    [Table("Pago")]
    public class Pago
    {
        [Key]
        [Required]
        public Guid Id { get; protected set; }
        public string tipoPago { get; set; }
        public int Monto { get; set; }
        public List<Notificacion> Notificaciones { get; set; }
        public List<Cupon> Cupones { get; set; }
        public Pago(string tipoPago, int Monto)
        {
            this.tipoPago = tipoPago;
            this.Monto = Monto;
            this.Notificaciones = new List<Notificacion>();
            this.Cupones = new List<Cupon>();
        }
        public void AgregarCupones(Cupon unCupon)
        {
            this.Cupones.Add(unCupon);
        }

        public void AgregarNotificaciones(Notificacion unaNotificacion)
        {
            this.Notificaciones.Add(unaNotificacion);
        }

        public void Actualizar(int monto)
        {
            this.Monto = monto;
        }

    }
}