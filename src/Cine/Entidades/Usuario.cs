
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Cine.Entidades

{
    [Table("Usuario")]
    public class Usuario
    {
        [Key]
        [Required]
        public Guid Id { get; protected set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public string Contrasena { get; set; }
        public List<Miembro> Miembros { get; set; }
        public List<Invitado> Invitados { get; set; }

        public void AgregarMiembro(Miembro unMiembro)
        {
            this.Miembros.Add(unMiembro);
        }
        public void AgregarInvitado(Invitado unInvitado)
        {
            this.Invitados.Add(unInvitado);
        }
        public Usuario(string nombre, string apellido, string email, string contrasena)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Email = email;
            this.Contrasena = contrasena;
            this.Invitados = new List<Invitado>();
            this.Miembros = new List<Miembro>();
        }
    }
}