using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salvador_Hernandez.Entity
{
    public class Examen

    {

        public int Id { set; get; }

        public string Nombre { set; get; }

        public string Descripcion { set; get; }

        public int Valor { set; get; }



        public Examen(int id, string nombre, string descripcion, int valor)

        {

            Id = id;

            Nombre = nombre;

            Descripcion = descripcion;

            Valor = valor;

        }

    }
}
