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

        //[Fact]
        //public void Notificacion_Visualizada()
        //{
        //Arrange
        //var notificacion = Notificacion();
        //var pago = Pago("Efectivo", 20);
        //Act
        //notificacion.Notificacion_Visualizada();
        //Assert 
    }
}