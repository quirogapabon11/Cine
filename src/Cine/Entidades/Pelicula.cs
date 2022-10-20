
namespace Cine.Entidades
{
    public class Pelicula
    {
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public string Idioma { get; set; }
        public string Genero { get; set; }
        public DateTime Lanzamiento { get; set; }
        public string Calidad { get; set; }
        public bool Duracion { get; set; }
        public void Administrador()
        {

        }
        public Pelicula(string titulo, string descripcion, string idioma, string genero, DateTime lanzamiento, string calidad, bool duracion)
        {
            this.Titulo = titulo;
            this.Descripcion = descripcion;
            this.Idioma = idioma;
            this.Genero = genero;
            this.Lanzamiento = lanzamiento;
            this.Calidad = calidad;
            this.Duracion = duracion;
        }

    }

}