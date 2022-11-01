using Cine.Entidades;

namespace Tests
{
    public class UsuarioTests
    {
        public void AgregarMiembro_DebeDarVerdadero()
        {
            var miembro = new Miembro(1, false);
            var invitado = new Invitado(17);

            usuario.AgregarInvitado(invitado);
            usuario.AgregarMiembro(miembro);


        }
    }
}