namespace Cine.Entidades
{
    public class CadenaCine
    {
        public string Nombre { get; set; }
        public List<Sede> Sedes { get; set; }

        public List<Miembro> Miembros { get; set; }

        public void AgregarMiembro(Miembro unMiembro)
        {
            this.Miembros.Add(unMiembro);
        }

        public CadenaCine(string nombre)
        {
            this.Nombre = nombre;
            this.Sedes = new List<Sede>();
            this.Miembros = new List<Miembro>();
        }

        public void AgregarSedes(Sede unaSede)
        {
            this.Sedes.Add(unaSede);
        }
    }
}