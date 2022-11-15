
using System.ComponentModel.DataAnnotations.Schema;
namespace Cine.Entidades
{
    [Table("Ciudad")]
    public class Ciudad
    {
        public int NroSede { get; set; }
        public Ciudad(int nroSede)
        {
            this.NroSede = nroSede;
        }
    }
}