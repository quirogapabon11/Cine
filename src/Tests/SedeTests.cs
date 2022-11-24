using Cine.Entidades;
namespace Tests
{
    public class SedeTests
    {
        [Fact]
        public void AgregarPelicula()
        {
            //Arrenge
            var pelicula = new Pelicula("Batman", "Batman es un hombre alto, caucásico, tiene una figura oscura e imponente, posee con cabello negro corto y ojos marrones. Él lleva un traje gris oscuro con el símbolo negro de un murciélago, en medio de el pecho. Batman también usa una capucha negra que lo cubre en todo momento para ocultar su identidad.", "Español", "Accion/Ficcion", DateTime.Now, "2D", 128);
            var sede = new Sede("Balvanera", "Av.Rivadavia", "Capital Federal");
            //Act
            sede.AgregarPelicula(pelicula);
            //Assert
            Assert.Contains(pelicula, sede.Peliculas);
        }

        [Fact]
        public void AgregarSala()
        {
            //Arrenge
            var sala = new Sala(25);
            var sede = new Sede("Balvanera", "Av.Rivadavia", "Capital Federal");
            //Act
            sede.AgregarSala(sala);
            //Assert
            Assert.Contains(sala, sede.Salas);
        }

        [Fact]
        public void AgregarCiudad()
        {
            //Arrenge
            var ciudad = new Ciudad(3);
            var sede = new Sede("Balvanera", "Av.Rivadavia", "Capital Federal");
            //Act
            sede.AgregarCiudad(ciudad);
            //Assert
            Assert.Contains(ciudad, sede.Ciudades);
        }

        [Fact]
        public void AgregarProyeccion()
        {
            //Arrenge 
            var proyeccion = new Proyeccion("Tu abuela", 1, 3, "Lo que sea", DateTime.Now);
            var sede = new Sede("Balvanera", "Av.Rivadavia", "Capital Federal");
            //Act
            sede.AgregarProyeccion(proyeccion);
            //Assert
            Assert.Contains(proyeccion, sede.Proyecciones);
        }
    }
}