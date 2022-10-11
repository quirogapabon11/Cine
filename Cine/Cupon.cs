using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cine
{
    public class Cupon
    {
        public bool Pago { get; set; }
        public void Descuento()
        {

        }
        public Cupon(bool pago)

        {
            this.Pago = pago;
        }
    }
}