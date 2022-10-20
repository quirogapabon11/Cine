
namespace Entidades
{
    public class Administrador : Usuario
    {
        public List<Sistema> Sistemas { get; set; }

        public Administrador(string nombre, string apellido, string email, string contrasena)
            : base(nombre, apellido, email, contrasena)
        {
            this.Sistemas = new List<Sistema>();
        }

        public void AgregarSistema(Sistema unSistema)
        {
            this.Sistemas.add(unSistema);
        }
        public void DardeAlta()
        {

        }

        public void DardeBaja()
        {

        }


    }
}