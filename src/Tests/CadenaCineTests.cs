using Cine.Entidades;

namespace Tests
{
    public class CadenaCineTests
    {
        [Fact]
        public void AgregarMiembros()
        {
            var miembro = new Miembro(false);
            CadenaCine.AgregarMiembro(unMiembro);
            Assert.Throws<Exception>(() => CadenaCine.AgregarMiembro(unMiembro));

        }

        [Fact]
        public void AgregarSedes()
        {
            var sede = new Sede("Avellaneda", "av.pepe", 4, "Gran BS AS", "Wakanda", "PanterA niga");
            var cine = new CadenaCine("PepCineMax");
            cine.AgregarSedes(sede);
            Assert.Throws<Exception>(() => cine.AgregarSedes(sede));
        }



    }
}