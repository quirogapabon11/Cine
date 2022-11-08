namespace Cine.Entidades;

public class Miembro
{
    public Guid Id { get; set; }
    public bool Habilitado { get; set; } = false;
    public List<Reserva> Reservas { get; set; }

    public void AgregarReserva(Reserva unaReserva)
    {
        this.Reservas.Add(unaReserva);
    }
    public void CancelarReserva(Reserva unaReserva)
    {
        this.Reservas.Remove(unaReserva);
    }

    public Miembro(bool habilitado)
    {
        this.Habilitado = habilitado;
        this.Id = Guid.NewGuid();
        this.Reservas = new List<Reserva>();
    }
}
