using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Presentacion.VIewModels
{
    public class ProyeccionViewModel
    {
        public string Pelicula { get; set; }
        public Guid idSala { get; set; }
        public Guid idCine { get; set; }
        public string Formato { get; set; }
        public DateTime Horario { get; set; }

        public string NroSede { get; set; }
    }
}