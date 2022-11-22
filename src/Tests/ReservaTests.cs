using Cine.Entidades;

namespace Tests
{
    public class ReservaTests
    {
        [Fact]
        public void AgregarPago()
        {
            //Arrange
            var proyeccion = new Proyeccion("Batman", 2, 3, "2D", DateTime.Now);
            var reserva = new Reserva(2, 5, false, 1, "jhjhkhg", proyeccion);
            var miembro = new Miembro(true);
            var pago = new Pago("Efectivo", 2000);

            //Act
            reserva.AgregarPago(pago);
            miembro.AgregarReserva(reserva);

            //Assert
            Assert.Contains(reserva, miembro.Reservas);
        }

    }
}