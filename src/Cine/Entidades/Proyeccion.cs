namespace Cine.Entidades
{
    public class Proyeccion
    {
        public string Pelicula { get; set; }
        public int Sala { get; set; }
        public int Cine { get; set; }
        public string Formato { get; set; }
        public DateTime Horario { get; set; }
        public Proyeccion(string pelicula, int sala, int cine, string formato, DateTime horario)
        {
            this.Pelicula = pelicula;
            this.Sala = sala;
            this.Cine = cine;
            this.Formato = formato;
            this.Horario = horario;
        }

        public void AgregarProyeccion(Proyeccion proyeccion)
        {
            throw new NotImplementedException();
        }

        public void DardeBajaProyeccion(Proyeccion proyeccion)
        {
            throw new NotImplementedException();
        }

        public void DardeAltaFuncion(Proyeccion proyeccion)
        {
            throw new NotImplementedException();
        }

        public void DardeBajaFuncion(Proyeccion proyeccion)
        {
            throw new NotImplementedException();
        }
    }
}