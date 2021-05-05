using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Salvador_Hernandez
{
     class PacienteDAO
    {
        private static List<Paciente> alPaciente = new List<Paciente>();
        private static int sw = 0;


        public static int getSW()
        {
            return sw;
        }

        public static void llenar()
        {
         
            alPaciente.Add(new Paciente(1, "Princesa", "Poodle", DateTime.Parse("12-12-2014"),
                "Femenino", "Poodle1.jpg", "111-1", "Alberto"));
            alPaciente.Add(new Paciente(2, "Timon", "Shih Tzu", DateTime.Parse("10-12-2018"),
                "Masculino", "foto", "111-1", "Alberto"));
            alPaciente.Add(new Paciente(3, "Cachupin", "Poodle", DateTime.Parse("01-12-2015"),
                "Masculino", "foto", "111-1", "Alberto"));
            alPaciente.Add(new Paciente(4, "Capitan", "Poodle", DateTime.Parse("02-10-2015"),
                "Masculino", "foto", "122-2", "Beatriz"));
            alPaciente.Add(new Paciente(5, "Ruperta", "Chihuahua", DateTime.Parse("03-11-2015"),
                "Masculino", "foto", "122-2", "Beatriz"));
            alPaciente.Add(new Paciente(6, "Dassy", "Bichon maltes", DateTime.Parse("04-06-2014"),
                 "Femenino", "foto", "122-2", "Beatriz"));
            alPaciente.Add(new Paciente(7, "Lupi", "Shih Tzu", DateTime.Parse("05-07-2018"),
                "Masculino", "foto", "133-3", "Carlos"));
            alPaciente.Add(new Paciente(8, "Muhic", "Beagle", DateTime.Parse("05-09-2015"),
                "Masculino", "foto", "133-3", "Carlos"));
            alPaciente.Add(new Paciente(9, "Bot", "Pastor alemán", DateTime.Parse("05-12-2015"),
                "Masculino", "foto", "133-3", "Carlos"));
            alPaciente.Add(new Paciente(10, "Baxter", "Poodle", DateTime.Parse("05-03-2015"),
                "Masculino", "foto", "144-4", "Daniel"));
            alPaciente.Add(new Paciente(11, "Negra", "Doberman", DateTime.Parse("12-01-2014"),
               "Femenino", "foto", "144-4", "Daniel"));
            alPaciente.Add(new Paciente(12, "Pelusa", "Husky siberiano", DateTime.Parse("10-01-2018"),
                "Masculino", "foto", "144-4", "Daniel"));
            alPaciente.Add(new Paciente(13, "Blanca", "Labrador", DateTime.Parse("05-09-2014"),
                "Masculino", "foto", "155-5", "Enrique"));
            alPaciente.Add(new Paciente(14, "Atom", "Pastor alemán", DateTime.Parse("05-05-2019"),
                "Masculino", "foto", "155-5", "Enrique"));
            alPaciente.Add(new Paciente(15, "Blusy", "Golden retriever", DateTime.Parse("05-12-2015"),
                "Masculino", "foto", "155-5", "Enrique"));
            sw = 1;
        }

        public static List<Paciente> ObtenerDatos()
        {
            return alPaciente;
        }

        public static bool Agregar(Paciente paciente)
        {
            bool estado = false;
            if (paciente != null)
            {
                alPaciente.Add(paciente);
                estado = true;
            }
            return estado;
        }

        public static Paciente Buscar(int id)
        {
            Paciente obj = null;
            foreach (Paciente pacientito in alPaciente)
            {
                if (pacientito.Id.Equals(id))
                {
                    obj = pacientito;
                    break;
                }
            }
            return obj;
        }

        public static bool Eliminar(int id)
        {
            bool estado = false;
            foreach (Paciente pacientito in alPaciente)
            {
                alPaciente.Remove(pacientito);
                estado = true;
                break;
            }
            return estado;
        }

        public static bool Modificar(Paciente paciente)
        {
            bool estado = false;
            foreach (Paciente pacientito in alPaciente)
            {
                alPaciente.Remove(pacientito);
                alPaciente.Add(paciente);
                estado = true;
                break;
            }
            return estado;
        }


    }
}