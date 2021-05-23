using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salvador_Hernandez.Entity
{
    public class Reserva
    {
        string Fecha;
        string Hora;
        string Veterinario;

        public string Fecha1 { get => Fecha; set => Fecha = value; }
        public string Hora1 { get => Hora; set => Hora = value; }
        public string Veterinario1 { get => Veterinario; set => Veterinario = value; }

        public Reserva(string fecha, string hora, string veterinario)
        {
            Fecha = fecha;
            Hora = hora;
            Veterinario = veterinario;
           
        }
    }
}
