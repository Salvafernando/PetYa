using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salvador_Hernandez.AccesoDatos
{
    public class Conexion
    {
       
        public string conectar()
        {
            return "Data Source=localhost;Initial Catalog=PETYA;Integrated Security=True";
        }
    }
}
