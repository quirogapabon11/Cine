using Cine.Entidades;

namespace Tests
{
    public class SalaTests
    {
        [Fact]
        public void AgregarReserva()
        {
            var sala = new Sala(2);
            var proyeccion = new Proyeccion("Tu abuela", 1, 3, "Lo que sea", DateTime.Now);
            var reserva = new Reserva(2, 5, false, 1, "jhjhkhg", proyeccion);
            sala.AgregarReserva(reserva);

            Assert.Contains(reserva, sala.Reservas);
            Assert.Throws<Exception>(() => sala.AgregarReserva(reserva));
        }

        [Fact]
        public void AgregarProyeccion()
        {
            var proyeccion = new Proyeccion("Pantera Rosa", 2, 3, "2D", DateTime.Now);
            var sala = new Sala(2);
            var proyecciones = new Proyeccion("Tu abuela", 1, 3, "Lo que sea", DateTime.Now);
            sala.AgregarProyeccion(proyecciones);
            Assert.Throws<Exception>(() => sala.AgregarProyeccion(proyecciones));
        }

        [Fact]
        public void DardeBajaProyeccion()
        {
            var proyeccion = new Proyeccion("Pantera Rosa", 2, 3, "2D", DateTime.Now);
            var sala = new Sala(2);
            var proyecciones = new Proyeccion("Tu abuela", 1, 3, "Lo que sea", DateTime.Now);
            sala.DardeBajaProyeccion(proyecciones);
            Assert.Throws<Exception>(() => sala.DardeBajaProyeccion(proyecciones));
        }
    }
}