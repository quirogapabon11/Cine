using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cine
{
    public class Sede
    {
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public int Salas { get; set; }
        public string Ciudad { get; set; }
        public string Proyeccion { get; set; }
        public string Pelicula { get; set; }
        public Sede(string nombre, string direccion, int salas, string ciudad, string proyeccion, string pelicula)
        {
            this.Nombre = nombre;
            this.Direccion = direccion;
            this.Salas = salas;
            this.Ciudad = ciudad;
            this.Proyeccion = proyeccion;
            this.Pelicula = pelicula;
        }
    }
}