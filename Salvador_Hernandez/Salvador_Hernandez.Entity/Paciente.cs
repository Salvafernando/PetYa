using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Salvador_Hernandez
{
    public class Paciente
    {
        public int id  { set; get; }
        public string nombreMascota { set; get; }
        public string raza { set; get; }
        public DateTime fechaNac { set; get; }
        public string genero { set; get; }
        public string foto { set; get; }
        public string rutDueno { set; get; }
        public string nombreDueno { set; get; }

        public Paciente(int id, string nombreMascota, string raza, DateTime fechaNac, string genero, string foto, string rutDueno, string nombreDueno)
        {
            this.id = id;
            this.nombreMascota = nombreMascota;
            this.raza = raza;
            this.fechaNac = fechaNac;
            this.genero = genero;
            this.foto = foto;
            this.rutDueno = rutDueno;
            this.nombreDueno = nombreDueno;
        }

      
    }

   
    
}