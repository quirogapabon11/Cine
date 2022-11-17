
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Cine.Entidades
{
    [Table("Invitado")]
    public class Invitado
    {
        [Key]
        [Required]
        public Guid Id { get; protected set; }
        public int Edad { get; set; }
        public Invitado(int edad)
        {
            this.Edad = edad;
        }
    }
}