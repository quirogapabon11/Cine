namespace Cine.Entidades
{
    public class Cupon
    {
        public bool descuento { get; set; }

        public Cupon(bool descuento)
        {
            this.descuento = descuento;
        }
    }
}