using Cine.Entidades;

namespace Tests
{
    public class SalaTests
    {
        [Fact]
        public void AgregarReserva()
        {
            var sala = new Sala(2);
            sala.AgregarReserva();
            Assert.Throws<Exception>(() => sala.AgregarReserva());
        }

        [Fact]
        public void AgregarProyeccion()
        {
            var proyeccion = new Proyeccion("Pantera Rosa", 2, 3, "2D", DateTime.Now);
            proyeccion.AgregarProyeccion(proyeccion);
            Assert.Throws<Exception>(() => proyeccion.AgregarProyeccion(proyeccion));
        }

        [Fact]
        public void DardeBajaProyeccion()
        {
            var proyeccion = new Proyeccion("Pantera Rosa", 2, 3, "2D", DateTime.Now);
            proyeccion.DardeBajaProyeccion(proyeccion);
            Assert.Throws<Exception>(() => proyeccion.DardeBajaProyeccion(proyeccion));
        }
    }
}