using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Salvador_Hernandez
{
    class Usuario
    {
        private string rut;
        private string nombre;
        private string username;
        private string password;
        public Usuario()
        {
        }

        public Usuario(string rut, string nombre, string username, string password)
        {
            this.Rut = rut;
            this.Nombre = nombre;
            this.Username = username;
            this.Password = password;
        }

        public string Rut { get => rut; set => rut = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }

        override
            public string ToString()
        {
            return Rut + ", " + Nombre + ", " + Username + ", " + Password;
        }
    }
}