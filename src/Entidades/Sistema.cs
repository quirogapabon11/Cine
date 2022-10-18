namespace Entidades
{
    public class Sistema
    {
        public CadenaCine Cine { get; set; }
        public int Reservas { get; set; }
        public int Miembros { get; set; }
        public List<Miembro> Miembros { get; set; }
        public List<CadenaCine> CadenaCines { get; set; }

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
        }
    }
}