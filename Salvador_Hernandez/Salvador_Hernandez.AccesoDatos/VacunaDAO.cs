using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Salvador_Hernandez.Entity;

namespace Salvador_Hernandez.AccesoDatos
{
   public class VacunaDAO
    {

        private static List<Vacuna> alPaciente = new List<Vacuna>();

        private static int sw = 0;





        public static int getSW()

        {

            return sw;

        }





        public static DataTable ObtenerDatos()

        {

            Conexion con = new Conexion();

            string sCnn = con.conectar();

            string sSel = "Select * from VACUNA";

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



        public static Boolean Agregar(Vacuna vacuna)

        {

            Boolean estado = true;

            string sCnn;

            try

            {

                Conexion c = new Conexion();

                sCnn = c.conectar();



                string sSel = "insert into VACUNA (ID_VACUNA, NOMBRE_VAC, DESC_VACUNA, VALOR_VAC, CANTIDAD_VAC) values(" +

                    vacuna.Id + ",'" + vacuna.Nombre + "','" + vacuna.Descripcion + "','" + vacuna.Valor +

                    "','" + vacuna.Cantidad + "');";

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



        public static Vacuna Buscar(int Id)

        {

            Vacuna obj = null;

            try

            {

                Conexion c = new Conexion();

                string sCnn = c.conectar();



                string sSel1 = "Select  * from VACUNA where ID_VACUNA=" + Id + "";

                SqlDataAdapter da1;

                DataTable dt1 = new DataTable();



                da1 = new SqlDataAdapter(sSel1, sCnn);

                da1.Fill(dt1);

                obj = new Vacuna(Id, dt1.Rows[0][1].ToString(), dt1.Rows[0][2].ToString(),

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



                string sSel = "delete from VACUNA where ID_VACUNA =" + id + ";";

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



        public static Boolean Modificar(Vacuna vacuna)

        {

            Boolean estado = true;

            try

            {

                Conexion c = new Conexion();

                string sCnn = c.conectar();



                string sSel = "update VACUNA set  NOMBRE_VAC='" + vacuna.Nombre +

                    "',DESC_VACUNA='" + vacuna.Descripcion + "',VALOR_VAC='" + vacuna.Valor +

                    "',CANTIDAD_VAC='" + vacuna.Cantidad + "' where ID_VACUNA=" +

                    vacuna.Id + ";";

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

                string sSel1 = "select v.NOMBRE_VAC, " +
                    "v.DESC_VACUNA, " +
                    "va.FECHA_ADM " +
                    "from VACUNA_ADMINISTRADAS va " +
                    "inner join vacuna v on" +
                    " (va.ID_VACUNA = v.ID_VACUNA) " +
                    "inner join FICHA_MASCOTA fa on " +
                    "(va.ID_FICHA = fa.ID_FICHA)" +
                    " where fa.ID_DUENO ='"+rut+"' and fa.NOMBRE= '"+nombre+"';";


                SqlDataAdapter da;

                da = new SqlDataAdapter(sSel1, sCnn);
                da.Fill(dt);
               
            }
            catch (Exception e) { }

            return dt;
        }

    }
}
