using Cine.Entidades;

namespace Tests
{
    public class ReservaTests
    {
        [Fact]
    public void AgregarPago()
    {
        //Arrange
        var proyeccion = new Proyeccion("Tu abuela", 1, 3, "Lo que sea", DateTime.Now);
        var reserva = new Reserva(2, 5, false, 1, "jhjhkhg", proyeccion);
        var miembro  = new Miembro(true);

        //Act
        reserva.AgregarPago();

        //Assert
        Assert.Contains(reserva, miembro.Reservas);
        }

    }
}