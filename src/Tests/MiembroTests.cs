using Cine.Entidades;

namespace Tests;

public class MiembroTests
{
    [Fact]
    public void AgregarReserva_DelUsuario_DebeDarVerdadero()
    {
        //Arrange
        var proyeccion = new Proyeccion("Tu abuela", new Guid(), new Guid(), "Lo que sea", DateTime.Now);
        var reserva = new Reserva(2, 5, false, 1, "jhjhkhg", proyeccion);
        var miembro = new Miembro(true);


        //Act
        miembro.AgregarReserva(reserva);

        //Assert
        Assert.Contains(reserva, miembro.Reservas);
    }
}