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
    public class ExamenDAO
    {
        private static List<Examen> alPaciente = new List<Examen>();

        private static int sw = 0;





        public static int getSW()

        {

            return sw;

        }





        public static DataTable ObtenerDatos()

        {

            Conexion con = new Conexion();

            string sCnn = con.conectar();

            string sSel = "Select * from EXAMEN";

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



        public static Boolean Agregar(Examen examen)

        {

            Boolean estado = true;

            string sCnn;

            try

            {

                Conexion c = new Conexion();

                sCnn = c.conectar();



                string sSel = "insert into EXAMEN (ID_EXAMEN, NOMBRE_EXAMEN, DESC_EXAMEN, VALOR_EXAMEN) values(" +

                    examen.Id + ",'" + examen.Nombre + "','" + examen.Descripcion + "','" + examen.Valor + "');";

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



        public static Examen Buscar(int Id)

        {

            Examen obj = null;

            try

            {

                Conexion c = new Conexion();

                string sCnn = c.conectar();



                string sSel1 = "Select  * from EXAMEN where ID_EXAMEN=" + Id + "";

                SqlDataAdapter da1;

                DataTable dt1 = new DataTable();



                da1 = new SqlDataAdapter(sSel1, sCnn);

                da1.Fill(dt1);

                obj = new Examen(Id, dt1.Rows[0][1].ToString(), dt1.Rows[0][2].ToString(),

                    Convert.ToInt32(dt1.Rows[0][3].ToString()));



            }

            catch (Exception e) { }



            return obj;

        }



        public static Boolean Eliminar(int id)

        {

            Boolean estado = true;

            try

            {

                Conexion c = new Conexion();

                string sCnn = c.conectar();



                string sSel = "delete from EXAMEN where ID_EXAMEN =" + id + ";";

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



        public static Boolean Modificar(Examen examen)

        {

            Boolean estado = true;

            try

            {

                Conexion c = new Conexion();

                string sCnn = c.conectar();



                string sSel = "update EXAMEN set  NOMBRE_EXAMEN='" + examen.Nombre +

                    "',DESC_EXAMEN='" + examen.Descripcion + "',VALOR_EXAMEN='" + examen.Valor +

                    "' where ID_EXAMEN=" + examen.Id + ";";

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

        public static DataTable BuscarFicha(string nombre, string rut)
        {
            DataTable dt = new DataTable();

            try
            {

                Conexion con = new Conexion();
                string sCnn = con.conectar();

                string sSel1 = "select e.nombre_examen," +
                    " e.desc_examen," +
                    " ec.fecha_atencion" +
                    " from examen e " +
                    "inner join examen_complementario ec" +
                    " on (e.ID_EXAMEN =ec.ID_EXA) " +
                    "inner join FICHA_MASCOTA fm " +
                    "on (ec.ID_ATENCION= fm.ID_FICHA) " +
                    " where fm.ID_DUENO ='" + rut + "' and fm.NOMBRE= '" + nombre + "';";


                SqlDataAdapter da;

                da = new SqlDataAdapter(sSel1, sCnn);
                da.Fill(dt);

            }
            catch (Exception e) { }

            return dt;
        }
    }
}
