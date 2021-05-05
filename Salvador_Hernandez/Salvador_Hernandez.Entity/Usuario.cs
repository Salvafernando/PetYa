using System.Text.RegularExpressions;

namespace Salvador_Hernandez
{
    public class Usuario

    {

        public string Rut { set; get; }

        public string PrimerNombre { set; get; }

        public string SegundoNombre { set; get; }

        public string ApellidoPaterno { set; get; }

        public string ApellidoMaterno { set; get; }

        public string Email { set; get; }

        public string PreguntaSecreta { set; get; }

        public string RespuestaSecreta { set; get; }

        public string TipoUsuario { set; get; }

        public string Estado { set; get; }

        public string Direccion { set; get; }

        public string Telefono { set; get; }

        public string Password { set; get; }



        public Usuario(string rut, string primerNombre, string segundoNombre, string apellidoPaterno, string apellidoMaterno, string email, string preguntaSecreta, string respuestaSecreta, string tipoUsuario, string estado, string direccion, string telefono, string password)

        {

            Rut = rut;

            PrimerNombre = primerNombre;

            SegundoNombre = segundoNombre;

            ApellidoPaterno = apellidoPaterno;

            ApellidoMaterno = apellidoMaterno;

            Email = email;

            PreguntaSecreta = preguntaSecreta;

            RespuestaSecreta = respuestaSecreta;

            TipoUsuario = tipoUsuario;

            Estado = estado;

            Direccion = direccion;

            Telefono = telefono;

            Password = password;

        }



        public static bool ValidaRut(string rut)

        {

            rut = rut.Replace(".", "").ToUpper();

            Regex expresion = new Regex("^([0-9]+-[0-9K])$");

            string dv = rut.Substring(rut.Length - 1, 1);

            if (!expresion.IsMatch(rut))

            {

                return false;

            }

            char[] charCorte = { '-' };

            string[] rutTemp = rut.Split(charCorte);

            if (dv != Digito(int.Parse(rutTemp[0])))

            {

                return false;

            }

            return true;

        }



        public static string Digito(int rut)

        {

            int suma = 0;

            int multiplicador = 1;

            while (rut != 0)

            {

                multiplicador++;

                if (multiplicador == 8)

                    multiplicador = 2;

                suma += (rut % 10) * multiplicador;

                rut = rut / 10;

            }

            suma = 11 - (suma % 11);

            if (suma == 11)

            {

                return "0";

            }

            else if (suma == 10)

            {

                return "K";

            }

            else

            {

                return suma.ToString();

            }

        }

    }
}