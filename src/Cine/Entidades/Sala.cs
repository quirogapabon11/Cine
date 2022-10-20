namespace Entidades
{
    public class Sala
    {
        public int Asientos { get; set; }
        public List<Reserva> Reservas { get; set; }
        public List<Proyeccion> Proyecciones { get; set; }


        public void AgregarReserva(Reserva unaReserva)
        {
            this.Reservas.Add(unaReserva);
        }

        public void AgregarProyeccion(Proyeccion unaProyeccion)
        {
            this.Proyecciones.Add(unaProyeccion);
        }

        public Sala(int asientos)
        {
            this.Asientos = asientos;
            this.Reservas = new List<Reserva>();
            this.Proyecciones = new List<Proyeccion>();
        }
    }
}