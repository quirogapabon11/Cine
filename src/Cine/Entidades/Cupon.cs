
using System.ComponentModel.DataAnnotations.Schema;
namespace Cine.Entidades
{
    [Table("Cupon")]
    public class Cupon
    {
        public int Descuento { get; set; }

        public Cupon(int Descuento)
        {
            this.Descuento = Descuento;
        }
    }
}