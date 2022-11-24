using Cine.Entidades;

namespace Tests
{
    public class CadenaCineTests
    {
        [Fact]
        public void AgregarMiembros()
        {
            var miembro = new Miembro(false);
            var cadenaCine = new CadenaCine("PepCineMax");
            cadenaCine.AgregarMiembro(miembro);
            //Assert.Throws<Exception>(() => cadenaCine.AgregarMiembro(miembro));
            Assert.Contains(miembro, cadenaCine.Miembros);

        }

        [Fact]
        public void AgregarSedes()
        {
            var sede = new Sede("Balvanera", "Av.Rivadavia", "Capital Federal");
            var cine = new CadenaCine("PepCineMax");
            cine.AgregarSedes(sede);
            //Assert.Throws<Exception>(() => cine.AgregarSedes(sede));
            Assert.Contains(sede, cine.Sedes);
        }
    }

}