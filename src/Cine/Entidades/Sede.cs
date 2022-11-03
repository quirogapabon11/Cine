using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cine.Entidades
{
    public class Sede
    {
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Ciudad { get; set; }
        public string Proyeccion { get; set; }
        public List<Pelicula> Peliculas { get; set; }
        public List<Sala> Salas { get; set; }
        public List<Ciudad> Ciudades { get; set; }
        public List<Proyeccion> Proyecciones { get; set; }
        public void AgregarPelicula(Pelicula unaPelicula)
        {
            this.Peliculas.Add(unaPelicula);
        }

        public void AgregarSala(Sala unaSala)
        {
            this.Salas.Add(unaSala);
        }

        public void AgregarCiudad(Ciudad unaCiudad)
        {
            this.Ciudades.Add(unaCiudad);
        }
        public void AgregarProyeccion(Proyeccion unaProyeccion)
        {
            this.Proyecciones.Add(unaProyeccion);
        }

        public Sede(string nombre, string direccion, int salas, string ciudad, string proyeccion, string pelicula)
        {
            this.Nombre = nombre;
            this.Direccion = direccion;
            this.Ciudad = ciudad;
            this.Proyeccion = proyeccion;
            this.Peliculas = new List<Pelicula>();
            this.Salas = new List<Sala>();
            this.Proyecciones = new List<Proyeccion>();
            this.Ciudades = new List<Ciudad>();



        }

        public void DardeAltaFuncion(Sede sede)
        {
            throw new NotImplementedException();
        }

        internal void DardeBajaProyeccion()
        {
            throw new NotImplementedException();
        }

        public void DardeBajaFuncion(Sede sede)
        {
            throw new NotImplementedException();
        }
    }
}