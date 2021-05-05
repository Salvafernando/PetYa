using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Salvador_Hernandez
{
    class Paciente
    {
        private int id = 0;
        private string nombreMascota;
        private string raza;
        private DateTime fechaNac;
        private string genero;
        private string foto;
        private string rutDueno;
        private string nombreDueno;


        public Paciente()
        {
        }

        public Paciente(int id, string nombreMascota, string raza, DateTime fechaNac, string genero, string foto, string rutDueno, string nombreDueno)
        {
            this.Id = id;
            this.NombreMascota = nombreMascota;
            this.Raza = raza;
            this.FechaNac = fechaNac;
            this.Genero = genero;
            this.Foto = foto;
            this.RutDueno = rutDueno;
            this.NombreDueno = nombreDueno;
        }

        public int Id { get => id; set => id = value; }
        public string NombreMascota { get => nombreMascota; set => nombreMascota = value; }
        public string Raza { get => raza; set => raza = value; }
        public DateTime FechaNac { get => fechaNac; set => fechaNac = value; }
        public string Genero { get => genero; set => genero = value; }
        public string Foto { get => foto; set => foto = value; }
        public string RutDueno { get => rutDueno; set => rutDueno = value; }
        public string NombreDueno { get => nombreDueno; set => nombreDueno = value; }

        override
             public string ToString()
        {
            return Id + ", " + NombreMascota + ", " + Raza + ", " + FechaNac + ", " + Genero + ", " + Foto + ", " +
                ", " + RutDueno + ", " + NombreDueno;
        }
    }

   
    
}