using Cine.Entidades;

namespace Tests
{
    public class AdministradorTests
    {
        [Fact]
        public void AgregarSistema()
        {
            var sistema = new Sistema(3, 3);
            sistema.AgregarSistema(sistema);
            Assert.Throws<Exception>(() => sistema.AgregarSistema(sistema));
        }

        [Fact]
        public void DardeAltaPelicula()
        {
            var pelicula = new Pelicula("Pantera Rosa", "Acicion/Comedia", "Español", "Acicion/Comedia", DateTime.Now, "3D", 185);
            pelicula.DardeAltaPelicula(pelicula);
            Assert.Throws<Exception>(() => pelicula.DardeAltaPelicula(pelicula));
        }

        [Fact]
        public void DardeBajaPelicula()
        {
            var pelicula = new Pelicula("Pantera Rosa", "Acicion/Comedia", "Español", "Acicion/Comedia", DateTime.Now, "3D", 126);
            pelicula.DardeBajaPelicula(pelicula);
            Assert.Throws<Exception>(() => pelicula.DardeBajaPelicula(pelicula));
        }

        [Fact]
        public void DardeAltaFuncion()
        {
            var sede = new Sede("Balvanera", "Av.Rivadavia", 3, "Capital Federal", "Smile", "Smile");
            var proyeccion = new Proyeccion("Smile", 3, 3, "2D", DateTime.Now);
            Assert.Throws<Exception>(() => sede.DardeAltaFuncion(sede));
            Assert.Throws<Exception>(() => proyeccion.DardeAltaFuncion(proyeccion));
        }

        [Fact]
        public void DardeBajaFuncion()
        {
            var sede = new Sede("Balvanera", "Av.Rivadavia", 3, "Capital Federal", "Smile", "Smile");
            var proyeccion = new Proyeccion("Smile", 3, 3, "2D", DateTime.Now);
            Assert.Throws<Exception>(() => sede.DardeBajaFuncion(sede));
            Assert.Throws<Exception>(() => proyeccion.DardeBajaFuncion(proyeccion));
        }
    }
}