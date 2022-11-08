using Cine.Entidades;

namespace Tests
{
    public class SalaTests
    {
        [Fact]
        public void AgregarReserva()
        {
<<<<<<< Updated upstream
            var sala = new Sala(2);
            var proyeccion = new Proyeccion("Tu abuela", 1, 3, "Lo que sea", DateTime.Now);
            var reserva = new Reserva(2, 5, false, 1, "jhjhkhg", proyeccion);
            sala.AgregarReserva(reserva);

            Assert.Contains(reserva, sala.Reservas);
            Assert.Throws<Exception>(() => sala.AgregarReserva(reserva));
=======
            var reserva = new Reserva(8, 15, false, 6, "Sede de Balvanera", );
>>>>>>> Stashed changes
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