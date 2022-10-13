
namespace Entidades
{
    public class Reserva
    {
        public int Nro { get; set; }
        public int NroAsiento { get; set; }
        public bool Estado { get; set; }
        public int NroSala { get; set; }
        public string NombreSede { get; set; }
        public int Proyeccion { get; set; }
        public List<Pago> Pagos { get; set; }
        public void Pago()
        {

        }
        public void Recepcion()
        {

        }

        public Reserva(int nro, int nroAsiento, bool estado, int nroSala, string nombreSede, int proyeccion)
        {
            this.Nro = nro;
            this.NroAsiento = nroAsiento;
            this.Estado = estado;
            this.NroSala = nroSala;
            this.NombreSede = nombreSede;
            this.Proyeccion = proyeccion;
            this.Pagos = new List<Pago>();

        }
    }
}