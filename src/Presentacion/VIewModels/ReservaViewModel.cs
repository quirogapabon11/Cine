using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Presentacion.VIewModels
{
    public class ReservaViewModel
    {
        public int Nro { get; set; }
        public int NroAsiento { get; set; }
        public bool Estado { get; set; } = true;
        public int NroSala { get; set; }
        public string NombreSede { get; set; }
        public Guid IdProyeccion { get; set; }
    }
}