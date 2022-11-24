using Cine.Entidades;

namespace Tests
{
    public class SistemaTests
    {
        [Fact]
        public void AgregarNotificaciones()
        {
            var notificacion = new Notificacion("Pepe@gmail.com");
            var Sistema = new Sistema(8, 8);
            Sistema.AgregarNotificaciones(notificacion);
            //Assert.Throws<Exception>(() => Sistema.AgregarNotificaciones(notificacion));
            Assert.Contains(notificacion, Sistema.Notificaciones);

        }

        [Fact]
        public void AgregarMiembros()
        {
            var miembro = new Miembro(false);
            var Sistema = new Sistema(8, 8);
            Sistema.AgregarMiembro(miembro);
            //Assert.Throws<Exception>(() => Sistema.AgregarMiembro(miembro));
            Assert.Contains(miembro, Sistema.Miembros);

        }

        [Fact]
        public void AgregarCine()
        {
            var cine = new CadenaCine("PepCineMax");
            var Sistema = new Sistema(8, 8);
            Sistema.AgregarCine(cine);
            //Assert.Throws<Exception>(() => Sistema.AgregarCine(cine));
            Assert.Contains(cine, Sistema.CadenasdeCines);
        }
    }
}