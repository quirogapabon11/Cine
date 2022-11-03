namespace Cine.Entidades
{
    public class Sistema
    {
        public int Reservas { get; set; }
        public List<Miembro> Miembros { get; set; }
        public List<CadenaCine> CadenasdeCines { get; set; }
        public List<Notificacion> Notificaciones { get; set; }

        public void AgregarNotificaciones(Notificacion unaNotificacion)
        {
            this.Notificaciones.Add(unaNotificacion);
        }

        public void AgregarMiembro(Miembro unMiembro)
        {
            this.Miembros.Add(unMiembro);
        }
        public void AgregarCine(CadenaCine unaCadenaCine)
        {
            this.CadenasdeCines.Add(unaCadenaCine);
        }


        public Sistema(int reservas, int miembros)
        {

            this.Reservas = reservas;
            this.Miembros = new List<Miembro>();
            this.CadenasdeCines = new List<CadenaCine>();
            this.Notificaciones = new List<Notificacion>();

        }
    }
}