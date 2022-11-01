using Cine.Entidades;
namespace Tests
{
    public class PagoTests
    {
        [Fact]
        public void CuponAgregado()
        {
            //Arrange
            var pago = new Pago("Efectivo", 20);
            //Act
            var cupon = new Cupon(20);
            //Assert
            descun
        }
    }
}