using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cine
{
    public class Proyeccion
    {
        public string Pelicula { get; set; }
        public int Sala { get; set; }
        public int Cine { get; set; }
        public string Formato { get; set; }
        public DateTime Horarios { get; set; }
    }
}