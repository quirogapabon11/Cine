using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Entidades
{
    public class Ciudad
    {
        public int NroSede { get; set; }
        public Ciudad(int nroSede)
        {
            this.NroSede = nroSede;
        }
    }
}