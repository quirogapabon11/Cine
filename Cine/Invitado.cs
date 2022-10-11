using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cine
{
    public class Invitado
    {
        public int Edad { get; set; }
        public Invitado(int edad)
        {
            this.Edad = edad;
        }
    }
}