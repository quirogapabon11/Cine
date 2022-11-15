
using System.ComponentModel.DataAnnotations.Schema;
namespace Cine.Entidades

{
    [Table("Notificacion")]
    public class Notificacion
    {
        public string Email { get; set; }

        public Notificacion(string email)
        {
            this.Email = email;

        }
    }
}