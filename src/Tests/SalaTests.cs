using Cine.Entidades;

namespace Tests
{
    public class SalaTests
    {
        [Fact]
        public void AgregarReserva()
        {
            var sala = new Sala(2);
            var proyeccion = new Proyeccion("Batman", 2, 3, "2D", DateTime.Now);
            var reserva = new Reserva(2, 5, false, 1, "jhjhkhg", proyeccion);
            sala.AgregarReserva(reserva);

            Assert.Contains(reserva, sala.Reservas);
        }

        [Fact]
        public void AgregarProyeccion()
        {
            var proyeccion = new Proyeccion("Batman", 2, 3, "2D", DateTime.Now);
            var sala = new Sala(2);
            var proyecciones = new Proyeccion("Batman", 2, 3, "2D", DateTime.Now);
            sala.AgregarProyeccion(proyecciones);
        }

        [Fact]
        public void DardeBajaProyeccion()
        {
            var proyeccion = new Proyeccion("Batman", 2, 3, "2D", DateTime.Now);
            var sala = new Sala(2);
            var proyecciones = new Proyeccion("Batman", 2, 3, "2D", DateTime.Now);
            sala.AgregarProyeccion(proyecciones);
            sala.DardeBajaProyeccion(proyecciones);
            Assert.DoesNotContain(proyeccion, sala.Proyecciones);
        }
    }
}