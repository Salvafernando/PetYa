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
    public class InsumoDAO

    {

        private static List<Insumo> alInsumos = new List<Insumo>();



        public static DataTable ObtenerDatos()

        {

            Conexion con = new Conexion();

            string sCnn = con.conectar();

            string sSel = "Select * from INSUMO";

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

        public static Boolean Agregar(Insumo insumo)

        {



            Boolean estado = true;

            string sCnn;

            try

            {

                Conexion c = new Conexion();

                sCnn = c.conectar();



                string sSel = "insert into INSUMO (ID_INSUMO,NOMBRE_INSUMO,DESC_INSUMO,VALOR_INSUMO,CANTIDAD_INSUMO) values("

                              + insumo.Id

                              + ",'"

                              + insumo.Nombre

                              + "','"

                              + insumo.Descripcion

                              + "',"

                              + insumo.Precio

                              + ","

                              + insumo.Cantidad

                              + ");";





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

        public static Insumo Buscar(int id)

        {

            Insumo ins = null;

            DataTable dt = new DataTable();

            try

            {

                Conexion c = new Conexion();

                string sCnn = c.conectar();



                string sSel = "Select * from INSUMO where ID_INSUMO = '" + id + "';";

                SqlDataAdapter da;





                da = new SqlDataAdapter(sSel, sCnn);

                da.Fill(dt);

                ins = new Insumo(id, dt.Rows[0][1].ToString(), dt.Rows[0][2].ToString(), Int32.Parse(dt.Rows[0][3].ToString()), Int32.Parse(dt.Rows[0][4].ToString()));





            }

            catch (Exception e) { }



            return ins;

        }



        public static Boolean Eliminar(int id)

        {

            Boolean estado = true;

            try

            {

                Conexion c = new Conexion();

                string sCnn = c.conectar();



                string sSel = "delete from INSUMO where ID_INSUMO =" + id + ";";

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



        public static Boolean Modificar(Insumo ins)

        {

            Boolean estado = true;

            try

            {

                Conexion c = new Conexion();

                string sCnn = c.conectar();



                string sSel = "update INSUMO set NOMBRE_INSUMO ='" + ins.Nombre +

                    "',DESC_INSUMO='" + ins.Descripcion + "',VALOR_INSUMO=" + ins.Precio +

                    ",CANTIDAD_INSUMO=" + ins.Cantidad + " where ID_INSUMO=" +

                    ins.Id + ";";

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
