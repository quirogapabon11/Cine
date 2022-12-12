
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Cine.Entidades
{
    [Table("CadenaCine")]
    public class CadenaCine
    {
        [Key]
        [Required]
        public Guid Id { get; protected set; }
        public string Nombre { get; set; }
        public List<Sede> Sedes { get; set; }

        public List<Miembro> Miembros { get; set; }

        public void AgregarMiembro(Miembro unMiembro)
        {
            this.Miembros.Add(unMiembro);
        }

        public CadenaCine(string nombre)
        {
            this.Nombre = nombre;
            this.Sedes = new List<Sede>();
            this.Miembros = new List<Miembro>();
        }

        public void AgregarSedes(Sede unaSede)
        {
            this.Sedes.Add(unaSede);
        }

        public void Actualizar(string nombre)
        {
            this.Nombre = nombre;
        }

    }
}