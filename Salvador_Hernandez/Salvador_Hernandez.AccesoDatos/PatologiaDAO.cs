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

    public class PatologiaDAO

    {

        public static DataTable ObtenerDatos()

        {

            Conexion con = new Conexion();

            string sCnn = con.conectar();

            string sSel = "Select * from PATOLOGIA";

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

        public static Boolean Agregar(Patologia pat)

        {



            Boolean estado = true;

            string sCnn;

            try

            {

                Conexion c = new Conexion();

                sCnn = c.conectar();



                string sSel = "insert into PATOLOGIA (NOMBRE_PAT,DESC_PAT) values('"

                              + pat.Nombre

                              + "','"

                              + pat.Descripcion

                              + "');";





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

        public static Patologia Buscar(int id)

        {

            Patologia pat = null;

            DataTable dt = new DataTable();

            try

            {

                Conexion c = new Conexion();

                string sCnn = c.conectar();



                string sSel = "Select * from PATOLOGIA where ID_PATOLOGIA = " + id + ";";

                SqlDataAdapter da;





                da = new SqlDataAdapter(sSel, sCnn);

                da.Fill(dt);

                pat = new Patologia(id, dt.Rows[0][1].ToString(), dt.Rows[0][2].ToString());





            }

            catch (Exception e) { }



            return pat;

        }



        public static Boolean Eliminar(int id)

        {

            Boolean estado = true;

            try

            {

                Conexion c = new Conexion();

                string sCnn = c.conectar();



                string sSel = "delete from PATOLOGIA where ID_PATOLOGIA =" + id + ";";

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



        public static Boolean Modificar(Patologia pat)

        {

            Boolean estado = true;

            try

            {

                Conexion c = new Conexion();

                string sCnn = c.conectar();



                string sSel = "update PATOLOGIA set NOMBRE_PAT ='" + pat.Nombre +

                    "',DESC_PAT='" + pat.Descripcion + "' where ID_PATOLOGIA=" +

                    pat.Id + ";";

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

    }

}

