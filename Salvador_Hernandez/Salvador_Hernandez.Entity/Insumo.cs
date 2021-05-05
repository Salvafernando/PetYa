using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salvador_Hernandez.Entity
{
    public class Insumo

    {

        private int id;

        private string nombre;

        private string descripcion;

        private int precio;

        private int cantidad;



        public int Id { get => id; set => id = value; }

        public String Nombre { get => nombre; set => nombre = value; }

        public String Descripcion { get => descripcion; set => descripcion = value; }

        public int Precio { get => precio; set => precio = value; }

        public int Cantidad { get => cantidad; set => cantidad = value; }



        public Insumo(int id, string nombre, string descripcion, int precio, int cantidad)

        {

            this.id = id;

            this.nombre = nombre;

            this.descripcion = descripcion;

            this.precio = precio;

            this.cantidad = cantidad;

        }

    }
}
