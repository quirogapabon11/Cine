namespace Cine.Entidades
{
    public class Pago
    {
        public string tipoPago { get; set; }
        public int Descuento { get; set; }
        public List<Notificacion> Notificaciones { get; set; }
        public List<Cupon> Cupones { get; set; }
        public Pago(string tipoPago, int descuento)
        {
            this.tipoPago = tipoPago;
            this.Descuento = descuento;
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

    }
}