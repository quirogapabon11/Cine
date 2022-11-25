
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Cine.Entidades
{
    [Table("Cupon")]
    public class Cupon
    {
        [Key]
        [Required]
        public Guid Id { get; protected set; }
        public int Descuento { get; set; }
        public string Codigo { get; set; }

        public Cupon(int Descuento, string Codigo)
        {
            this.Descuento = Descuento;
            this.Codigo = Codigo;
        }
    }
}