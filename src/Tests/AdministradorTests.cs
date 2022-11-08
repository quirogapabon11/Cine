using Cine.Entidades;

namespace Tests
{
    public class AdministradorTests
    {
        [Fact]
        public void AgregarSistema()
        {
            var sistema = new Sistema(3, 3);
            var administrador = new Administrador("Pepe", "rene", "pepR@123", "4444");
            administrador.AgregarSistema(sistema);
            Assert.Contains(sistema, administrador.Sistemas);
        }

        [Fact]
        public void DardeAltaPelicula()
        {
            var pelicula = new Pelicula("Batman", "Batman es un hombre alto, caucásico, tiene una figura oscura e imponente, posee con cabello negro corto y ojos marrones. Él lleva un traje gris oscuro con el símbolo negro de un murciélago, en medio de el pecho. Batman también usa una capucha negra que lo cubre en todo momento para ocultar su identidad.", "Español", "Accion/Ficcion", DateTime.Now, "2D", 128);
            var administrador = new Administrador("Pepe", "rene", "pepR@123", "4444");
            administrador.DardeAltaPelicula(pelicula);
            Assert.Contains(pelicula, administrador.Peliculas);
        }

        [Fact]
        public void DardeBajaPelicula()
        {
            var pelicula = new Pelicula("Batman", "Batman es un hombre alto, caucásico, tiene una figura oscura e imponente, posee con cabello negro corto y ojos marrones. Él lleva un traje gris oscuro con el símbolo negro de un murciélago, en medio de el pecho. Batman también usa una capucha negra que lo cubre en todo momento para ocultar su identidad.", "Español", "Accion/Ficcion", DateTime.Now, "2D", 128);
            var administrador = new Administrador("Pepe", "rene", "pepR@123", "4444");
            administrador.DardeBajaPelicula(pelicula);
            Assert.Contains(pelicula, administrador.Peliculas);
        }

        [Fact]
        public void DardeAltaFuncion()
        {
            var sede = new Sede("Balvanera", "Av.Rivadavia", 3, "Capital Federal", "Smile", "Smile");
            var proyeccion = new Proyeccion("Tu abuela", 1, 3, "Lo que sea", DateTime.Now);
            sede.AgregarProyeccion(proyeccion);
            Assert.Contains(proyeccion, sede.Proyecciones);
        }

        [Fact]
        public void DardeBajaFuncion()
        {
            var sede = new Sede("Balvanera", "Av.Rivadavia", 3, "Capital Federal", "Smile", "Smile");
            var proyeccion = new Proyeccion("Tu abuela", 1, 3, "Lo que sea", DateTime.Now);
            sede.RemoveProyeccion(proyeccion);
            Assert.Contains(proyeccion, sede.Proyecciones);
        }
    }
}