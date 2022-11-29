
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Cine.Entidades

{
    [Table("Notificacion")]
    public class Notificacion
    {
        [Key]
        [Required]
        public Guid Id { get; protected set; }
        public string Email { get; set; }

        public Notificacion(string email)
        {
            this.Email = email;

        }

        public void Actualizar(string email)
        {
            this.Email = email;
        }
    }
}