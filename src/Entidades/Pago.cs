using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Entidades
{
    public class Pago
    {
        public bool Credito { get; set; }
        public bool Efectivo { get; set; }
        public bool Debito { get; set; }
        public bool PagoDigital { get; set; }
        public int Descuento { get; set; }
        public List<Notificacion> Notificaciones { get; set; }
        public void esCredito()
        {

        }
        public void esEfectivo()
        {

        }
        public void esDebito()
        {

        }
        public void esQr()
        {

        }
        public Pago(bool credito, bool efectivo, bool debito, bool pagoDigital, int descuento)
        {
            this.Credito = credito;
            this.Efectivo = efectivo;
            this.Debito = debito;
            this.PagoDigital = pagoDigital;
            this.Descuento = descuento;
            this.Notificaciones = new List<Notificacion>();
        }
        public void AgregarCupones(Cupon unCupon)
        {
            this.Cupones.Add(unCupon);
        }
    }
}