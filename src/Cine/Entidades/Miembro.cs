
using System.ComponentModel.DataAnnotations.Schema;
namespace Cine.Entidades;

[Table("Miembro")]
public class Miembro
{
    public Guid Id { get; set; }
    public bool Habilitado { get; set; } = false;
    public List<Reserva> Reservas { get; set; }
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public string Email { get; set; }
    public string Contrasena { get; set; }
    public List<Invitado> Invitados { get; set; }


    public void AgregarReserva(Reserva unaReserva)
    {
        this.Reservas.Add(unaReserva);
    }
    public void CancelarReserva(Reserva unaReserva)
    {
        this.Reservas.Remove(unaReserva);
    }

    public void AgregarInvitado(Invitado unInvitado)
    {
        this.Invitados.Add(unInvitado);
    }

    public Miembro(bool habilitado)
    {
        this.Habilitado = habilitado;
        this.Id = Guid.NewGuid();
        this.Reservas = new List<Reserva>();
    }

    public void Actualizar(bool habilitado, string apellido, string contrasena, string email, string nombre)
    {
        this.Habilitado = habilitado;
        this.Apellido = apellido;
        this.Contrasena = contrasena;
        this.Email = email;
        this.Nombre = nombre;
    }

    public Miembro(string nombre, string apellido, string email, string contrasena)
    {
        this.Nombre = nombre;
        this.Apellido = apellido;
        this.Email = email;
        this.Contrasena = contrasena;
        this.Invitados = new List<Invitado>();
    }

}
