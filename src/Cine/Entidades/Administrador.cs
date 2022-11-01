
namespace Cine.Entidades
{
    public class Administrador : Usuario
    {
        public List<Sistema> Sistemas { get; set; }
        public List<Pelicula> Peliculas { get; set; }
        public List<Sede> Sedes { get; set; }

        public Administrador(
            string nombre,
            string apellido,
            string email,
            string contrasena)
            : base(nombre, apellido, email, contrasena)
        {
            this.Sistemas = new List<Sistema>();
        }

        public void AgregarSistema(Sistema unSistema)
        {
            this.Sistemas.Add(unSistema);
        }
        public void DardeAltaPelicula(Pelicula unaPelicula)
        {
            this.Peliculas.Add(unaPelicula);
        }

        public void DardeBajaPelicula(Pelicula unaPelicula)
        {
            this.Peliculas.Remove(unaPelicula);
        }

        public void DardeAltaFuncion(Sede unaSede, Proyeccion unaProyeccion)
        {
            unaSede.AgregarProyeccion(unaProyeccion);
        }

        public void DardeBajaFuncion(Sede unaSede, Proyeccion unaProyeccion) => unaSede.DardeBajaProyeccion();

    }
}