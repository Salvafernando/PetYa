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
    public class FarmacoDAO
    {
        private static List<Farmaco> alPaciente = new List<Farmaco>();

        private static int sw = 0;





        public static int getSW()

        {

            return sw;

        }





        public static DataTable ObtenerDatos()

        {

            Conexion con = new Conexion();

            string sCnn = con.conectar();

            string sSel = "Select * from FARMACO";

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



        public static Boolean Agregar(Farmaco farmaco)

        {

            Boolean estado = true;

            string sCnn;

            try

            {

                Conexion c = new Conexion();

                sCnn = c.conectar();



                string sSel = "insert into FARMACO (ID_FARMACO, NOMBRE_FARMACO, DESC_FARMACO, VALOR_FARMACO, CANTIDAD_FARMACO) values(" +

                    farmaco.Id + ",'" + farmaco.Nombre + "','" + farmaco.Descripcion + "','" + farmaco.Valor +

                    "','" + farmaco.Cantidad + "');";

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



        public static Farmaco Buscar(int Id)

        {

            Farmaco obj = null;

            try

            {

                Conexion c = new Conexion();

                string sCnn = c.conectar();



                string sSel1 = "Select  * from FARMACO where ID_FARMACO=" + Id + "";

                SqlDataAdapter da1;

                DataTable dt1 = new DataTable();



                da1 = new SqlDataAdapter(sSel1, sCnn);

                da1.Fill(dt1);

                obj = new Farmaco(Id, dt1.Rows[0][1].ToString(), dt1.Rows[0][2].ToString(),

                    Convert.ToInt32(dt1.Rows[0][3].ToString()), Convert.ToInt32(dt1.Rows[0][4].ToString()));



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



                string sSel = "delete from FARMACO where ID_FARMACO =" + id + ";";

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



        public static Boolean Modificar(Farmaco farmaco)

        {

            Boolean estado = true;

            try

            {

                Conexion c = new Conexion();

                string sCnn = c.conectar();



                string sSel = "update FARMACO set  NOMBRE_FARMACO='" + farmaco.Nombre +

                    "',DESC_FARMACO='" + farmaco.Descripcion + "',VALOR_FARMACO='" + farmaco.Valor +

                    "',CANTIDAD_FARMACO='" + farmaco.Cantidad + "' where ID_FARMACO=" +

                    farmaco.Id + ";";

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

                string sSel1 = "select f.nombre_farmaco," +
                    " f.desc_farmaco," +
                    " fa.fecha_atencion " +
                    "from farmaco f" +
                    " inner join FARMACO_ADMINISTRADO fa " +
                    "on (f.ID_FARMACO=fa.ID_FARMACO) " +
                    "inner join FICHA_MASCOTA fm " +
                    "on (fa.ID_ATENCION=fm.ID_FICHA) " +
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
