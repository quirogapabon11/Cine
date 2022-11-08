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
            var cupon = new Cupon(20);
            //Act
            pago.AgregarCupones(cupon);
            //Assert
            Assert.Contains(cupon, pago.Cupones);
        }

        [Fact]
        public void AgregarNotificaciones()
        {
            //Arrange
            var notificacion = new Notificacion("Pepe@gmail.com");
            var pago = new Pago("Efectivo", 20);
            //Act
            pago.AgregarNotificaciones(notificacion);
            //Assert 
            Assert.Contains(notificacion, pago.Notificaciones);
        }
    }
}