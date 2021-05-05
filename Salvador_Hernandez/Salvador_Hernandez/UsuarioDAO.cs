using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Salvador_Hernandez
{
    class UsuarioDAO
    {
        private static List<Usuario> alUsuarios = new List<Usuario>();
        private static int sw = 0;


        public static int getSW() 
        {
            return sw;
        }

        public static void llenar()
        {
            alUsuarios.Add(new Usuario("111-1", "Alberto", "aconcha", "123456"));
            alUsuarios.Add(new Usuario("122-2", "Beatriz", "bcabello", "123456"));
            alUsuarios.Add(new Usuario("133-3", "Carlos", "calarcon", "123456"));
            alUsuarios.Add(new Usuario("144-4", "Daniel", "dbello", "123456"));
            alUsuarios.Add(new Usuario("155-5", "Enrique", "eortega", "123456"));

            sw = 1;
        }

        public static List<Usuario> ObtenerDatos()
        {
            return alUsuarios;
        }

        public static bool Agregar(Usuario usuario)
        {
            bool estado = false;
            if (usuario != null)
            {
                alUsuarios.Add(usuario);
                estado = true;
            }
            return estado;
        }

        public static Usuario Buscar(string rut)
        {
            Usuario obj = null;
            foreach (Usuario usuarito in alUsuarios)
            {
                if (usuarito.Rut.Equals(rut))
                {
                    obj = usuarito;
                    break;
                }
            }
            return obj;
        }

        public static Usuario Login(string usuario,string password)
        {
            Usuario obj = null;
            foreach (Usuario usuarito in alUsuarios)
            {
                if (usuarito.Username.Equals(usuario) && usuarito.Password.Equals(password))
                {
                    obj = usuarito;
                    break;
                }
            }
            return obj;
        }
        public static bool Eliminar(string rut)
        {
            bool estado = false;
            foreach (Usuario usuarito in alUsuarios)
            {
                alUsuarios.Remove(usuarito);
                estado = true;
                break;
            }
            return estado;
        }

        public static bool Modificar(Usuario usuario)
        {
            bool estado = false;
            foreach (Usuario usuarito in alUsuarios)
            {
                alUsuarios.Remove(usuarito);
                alUsuarios.Add(usuario);
                estado = true;
                break;
            }
            return estado;
        }
    }
}