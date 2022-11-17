
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Cine.Entidades
{
    [Table("Ciudad")]
    public class Ciudad
    {
        [Key]
        [Required]
        public Guid Id { get; protected set; }
        public int NroSede { get; set; }
        public Ciudad(int nroSede)
        {
            this.NroSede = nroSede;
        }
    }
}