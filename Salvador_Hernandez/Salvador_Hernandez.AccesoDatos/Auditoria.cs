using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Salvador_Hernandez.AccesoDatos
{
    public class Auditoria

    {



        public static DataTable ObtenerDatos()

        {

            Conexion con = new Conexion();

            string sCnn = con.conectar();

            string sSel = "select * from V_auditUsuario;";

            SqlDataAdapter da;

            DataTable dt = new DataTable();



            try

            {

                da = new SqlDataAdapter(sSel, sCnn);

                da.Fill(dt);

            }

            catch (Exception e)

            { }

            return dt;





        }



        public static DataTable Buscar(string accion)

        {

            DataTable dt = new DataTable();

            try

            {

                Conexion c = new Conexion();

                string sCnn = c.conectar();



                string sSel = "select * from V_auditUsuario where accion= '" + accion + "';";

                SqlDataAdapter da;





                da = new SqlDataAdapter(sSel, sCnn);

                da.Fill(dt);







            }

            catch (Exception e) { }



            return dt;

        }



        public static DataTable ObtenerDatosFichas()

        {

            Conexion con = new Conexion();

            string sCnn = con.conectar();

            string sSel = "select * from V_auditFichas;";

            SqlDataAdapter da;

            DataTable dt = new DataTable();



            try

            {

                da = new SqlDataAdapter(sSel, sCnn);

                da.Fill(dt);

            }

            catch (Exception e) { }

            return dt;





        }



        public static DataTable BuscarAFicha(string accion)

        {

            DataTable dt = new DataTable();

            try

            {

                Conexion c = new Conexion();

                string sCnn = c.conectar();



                string sSel = "select * from V_auditFicha where accion= '" + accion + "';";

                SqlDataAdapter da;





                da = new SqlDataAdapter(sSel, sCnn);

                da.Fill(dt);







            }

            catch (Exception e) { }



            return dt;

        }

    }
}
