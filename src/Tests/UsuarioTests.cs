using Cine.Entidades;

namespace Tests;

public class UsuarioTests
{
    [Fact]
    public void AgregarMiembro()
    {
        var usuario = new Usuario("Maria", "Mendez", "mariamendez35@gmail.com", "54io2");
        var miembro = new Miembro(false);
        usuario.AgregarMiembro(miembro);
        Assert.Contains(miembro, usuario.Miembros);


        var invitado = new Invitado(17);
        usuario.AgregarInvitado(invitado);


    }
}