using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Presentacion.VIewModels
{
    public class PeliculaViewModel
    {
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public string Idioma { get; set; }
        public string Genero { get; set; }
        public DateTime Lanzamiento { get; set; }
        public string Calidad { get; set; }
        public decimal Duracion { get; set; }
    }
}