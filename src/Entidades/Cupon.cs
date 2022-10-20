namespace Cine.Entidades
{
    public class Cupon
    {
        public bool Pago { get; set; }
        public void Descuento()
        {

        }
        public Cupon(bool pago)

        {
            this.Pago = pago;
        }
    }
}