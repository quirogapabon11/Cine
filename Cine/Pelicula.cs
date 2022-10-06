using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cine
{
    public class Pelicula
    {
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public string Idioma { get; set; }
        public string Genero { get; set; }
        public DateTime Lanzamiento { get; set; }
    }
}