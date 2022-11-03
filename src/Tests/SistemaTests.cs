using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cine.Entidades;
using Xunit;

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
            Assert.Throws<Exception>(() => Sistema.AgregarNotificaciones(notificacion));

        }

        [Fact]
        public void AgregarMiembros()
        {
            var miembro = new Miembro(false);
            var Sistema = new Sistema(8, 8);
            Sistema.AgregarMiembro(miembro);
            Assert.Throws<Exception>(() => Sistema.AgregarMiembro(miembro));

        }

        [Fact]
        public void AgregarCine()
        {
            var cine = new CadenaCine("cineMaxPro");
            var Sistema = new Sistema(8, 8);
            Sistema.AgregarCine(cine);
            Assert.Throws<Exception>(() => Sistema.AgregarCine(cine));
        }
    }
}