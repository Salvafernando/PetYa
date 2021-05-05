using Salvador_Hernandez.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salvador_Hernandez.AccesoDatos
{
    public class VeterinarioDAO
    {
        private static List<Veterinario> alVeterinario = new List<Veterinario>();

        public static DataTable ObtenerDatos()
        {
            Conexion con = new Conexion();
            string sCnn = con.conectar();
            string sSel = "Select RUT_VET,NOMBRE_VET,PRI_APELLIDO_VET,SEC_APPELLIDO_VET,FONO_VET,EMAIL_VET,ID_ROL,ID_PERFIL from VETERINARIO";
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
        public static Boolean Eliminar(string rut)
        {
            Boolean estado = true;
            try
            {
                Conexion c = new Conexion();
                string sCnn = c.conectar();

                string sSel = "Delete from VETERINARIO where RUT_VET = '" + rut + "';";
                SqlDataAdapter da;
                DataTable dt = new DataTable();


                da = new SqlDataAdapter(sSel, sCnn);
                da.Fill(dt);



            }
            catch (Exception e)
            {
                estado = false;
            }

            return estado;
        }

        public static DataTable Buscar(string rut)
        {
            DataTable dt = new DataTable();
            try
            {
                Conexion c = new Conexion();
                string sCnn = c.conectar();

                string sSel = "Select RUT_VET,NOMBRE_VET,PRI_APELLIDO_VET,SEC_APPELLIDO_VET,FONO_VET,EMAIL_VET,ID_ROL,ID_PERFIL from VETERINARIO where RUT_VET = '" + rut + "';";
                SqlDataAdapter da;


                da = new SqlDataAdapter(sSel, sCnn);
                da.Fill(dt);



            }
            catch (Exception e) { }

            return dt;
        }
    }
}
