namespace Entidades
{
    public class Notificacion
    {
        public string Email { get; set; }
        public Notificacion(string email)

        {
            this.Email = email;
        }
    }
}