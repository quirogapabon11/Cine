namespace Cine
{
    public class CadenaCine
    {
        public string Nombre { get; set; }
        public List<Sede> Sedes { get; set; }

        public List<Miembro> Miembros { get; set; }
        public CadenaCine(string nombre)
        {
            this.Nombre = nombre;
            this.Sedes = new List<Sede>();
            this.Miembros = new List<Miembro>();
        }

        public void Agregar(Sede unaSede)
        {
            this.Sedes.Add(unaSede);
        }
    }
}