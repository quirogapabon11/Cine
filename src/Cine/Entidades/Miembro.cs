namespace Cine.Entidades
{
    public class Miembro
    {
        public Guid Id { get; set; }
        public string Habilitado { get; set; }
        public string Lista { get; set; }

        public List<Reserva> Reservas { get; set; }

        public void AgregarReserva(Reserva unaReserva)
        {
            this.Reservas.Add(unaReserva);
        }



        public Miembro(string habilitado, string lista)
        {
            this.Habilitado = habilitado;
            this.Lista = lista;
            this.Reservas = new List<Reserva>();

        }

    }
}
