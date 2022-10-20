namespace Cine.Entidades
{
    public class Sistema
    {
        public CadenaCine Cine { get; set; }
        public int Reservas { get; set; }
        public int Miembros { get; set; }
        public List<Miembro> Miembros { get; set; }
        public List<CadenaCine> CadenasdeCines { get; set; }
        public List<Notificacion> Notificaciones { get; set; }

        public void AgregarNotificaciones(Notificacion unaNotificacion)
        {
            this.Notificaciones.add(unaNotificacion);
        }

        public void AgregarMiembro(Miembro unMiembro)
        {
            this.Miembros.Add(unMiembro);
        }
        public void AgregarCine(CadenaCine unaCadenaCine)
        {
            this.CadenasdeCines.Add(unaCadenaCine);
        }
        public void Notificar()
        {

        }

        public void Reembolso()
        {

        }

        public Sistema(CadenaCine cine, int reservas, int miembros)
        {
            this.Cine = cine;
            this.Reservas = reservas;
            this.Miembros = miembros;
            this.Miembros = new List<Miembro>();
            this.CadenaCines = new List<CadenaCine>();
            this.Notificaciones = new List<Notificacion>();

        }
    }
}