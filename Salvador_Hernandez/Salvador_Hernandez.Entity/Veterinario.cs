using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salvador_Hernandez.Entity
{
    public class Veterinario
    {
        public String Rut { set; get; }

        public String Nombre { set; get; }

        public String ApellidoP { set; get; }

        public String ApellidoM { set; get; }

        public String Numero { set; get; }

        public String Email { set; get; }

        public Veterinario(string rut, string nombre, string apellidoP, string apellidoM, string numero, string email)
        {
            Rut = rut;
            Nombre = nombre;
            ApellidoP = apellidoP;
            ApellidoM = apellidoM;
            Numero = numero;
            Email = email;
        }
    }
}
