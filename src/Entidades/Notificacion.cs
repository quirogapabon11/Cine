using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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