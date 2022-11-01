using Cine.Entidades;

namespace Tests
{
    public class CadenaCineTests
    {
        [Fact]
        public void AgregarMiembros()
        {
            var cadenaCine = new CadenaCine("GoCineMax");
            cadenaCine.AgregarMiembros();

            Assert.Throws<Exception>(() => cadenaCine.AgregarMiembros());

        }

        [Fact]
        public void AgregarSedes()
        {
            var cadenaCine = new CadenaCine("GoCineMax");


            cadenaCine.AgregarSedes();

            Assert.Throws<Exception>(() => cadenaCine.AgregarSedes());
        }



    }
}