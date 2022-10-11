using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cine
{
    public class Sistema
    {
        public CadenaCine Cine { get; set; }
        public int Reservas { get; set; }
        public int Miembros { get; set; }


        public void Notificar()
        {

        }

        public void Reembolso()
        {

        }

        public Sistema(CadenaCine cine, int reservas, int miembros)
        {
            this.Cine = cine;
            this.Reservas = reservas;
            this.Miembros = miembros;
        }
    }
}