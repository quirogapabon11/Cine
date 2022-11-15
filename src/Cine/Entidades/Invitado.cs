
using System.ComponentModel.DataAnnotations.Schema;
namespace Cine.Entidades
{
    [Table("Invitado")]
    public class Invitado
    {
        public int Edad { get; set; }
        public Invitado(int edad)
        {
            this.Edad = edad;
        }
    }
}