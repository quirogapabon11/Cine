using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cine
{
    public class Miembro
    {
        public Guid Id { get; set; }
        public string Habilitado { get; set; }
        public string Lista { get; set; }
        public Miembro(string habilitado, string lista)
        {
            this.Habilitado = habilitado;
            this.Lista = lista;
        }
    }
}