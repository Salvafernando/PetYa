using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salvador_Hernandez.AccesoDatos
{
    public class Reporterias
    {
        public static DataTable ObtenerDatosExamenesapli()

        {
            Conexion con = new Conexion();

            string sCnn = con.conectar();

            string sSel = "select * from V_examenesaplicados;";

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



        public static DataTable BuscarExamenes(string id)

        {
            DataTable dt = new DataTable();
            try

            {
                Conexion c = new Conexion();
                string sCnn = c.conectar();
                string sSel = "select * from V_examenesaplicados where ID_DUENO= '" + id + "';";
                SqlDataAdapter da;
                da = new SqlDataAdapter(sSel, sCnn);
                da.Fill(dt);
            }
            catch (Exception e) { }
            return dt;

        }

        public static DataTable ObtenerDatosFarmacosapli()

        {
            Conexion con = new Conexion();

            string sCnn = con.conectar();

            string sSel = "select * from V_farmacosaplicados;";

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



        public static DataTable BuscarFarmacos(string id)

        {
            DataTable dt = new DataTable();
            try

            {
                Conexion c = new Conexion();
                string sCnn = c.conectar();
                string sSel = "select * from V_farmacosaplicados where ID_DUENO= '" + id + "';";
                SqlDataAdapter da;
                da = new SqlDataAdapter(sSel, sCnn);
                da.Fill(dt);
            }
            catch (Exception e) { }
            return dt;

        }
    }
}
