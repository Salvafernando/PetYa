using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salvador_Hernandez.Entity
{
    public class Mascota
    {
       

        public string rutDueno { set; get; }
        public string nombreMascota { set; get; }
        public string raza { set; get; }
       
        public DateTime fechaNac { set; get; }
        public string genero { set; get; }


        public Mascota( string rutDueno, string nombreMascota, string raza, DateTime fechaNac, string genero)
        {
        
            this.rutDueno = rutDueno;
            this.nombreMascota = nombreMascota;
            this.raza = raza;
            this.fechaNac = fechaNac;
            this.genero = genero;
          
        }
    }
}
