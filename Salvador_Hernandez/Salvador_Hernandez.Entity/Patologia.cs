using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salvador_Hernandez.Entity
{
    public class Patologia

    {

        private int id;

        private string nombre;

        private string descripcion;





        public int Id { get => id; set => id = value; }

        public String Nombre { get => nombre; set => nombre = value; }

        public String Descripcion { get => descripcion; set => descripcion = value; }



        public Patologia(int id, string nombre, string descripcion)

        {

            this.id = id;

            this.nombre = nombre;

            this.descripcion = descripcion;

        }

    }
}
