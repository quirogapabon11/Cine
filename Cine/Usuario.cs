using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cine
{
    public class Usuario
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public string Contrasena { get; set; }
        public Usuario(string nombre, string apellido, string email, string contrasena)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Email = email;
            this.Contrasena = contrasena;
        }
    }
}