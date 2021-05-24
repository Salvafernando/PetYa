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

            string sSel = "select * from V_auditFicha;";

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
        public static DataTable ObtenerDatosReserva()

        {
            Conexion con = new Conexion();

            string sCnn = con.conectar();

            string sSel = "select * from V_auditReserva;";

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



        public static DataTable BuscarReserva(string accion)

        {
            DataTable dt = new DataTable();
            try

            {
                Conexion c = new Conexion();
                string sCnn = c.conectar();
                string sSel = "select * from V_auditReserva where accion= '" + accion + "';";
                SqlDataAdapter da;
                da = new SqlDataAdapter(sSel, sCnn);
                da.Fill(dt);
            }
            catch (Exception e) { }
            return dt;

        }

        public static DataTable ObtenerDatosVacuna()

        {
            Conexion con = new Conexion();

            string sCnn = con.conectar();

            string sSel = "select * from V_auditVacuna;";

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



        public static DataTable BuscarVacuna(string accion)

        {
            DataTable dt = new DataTable();
            try

            {
                Conexion c = new Conexion();
                string sCnn = c.conectar();
                string sSel = "select * from V_auditVacuna where accion= '" + accion + "';";
                SqlDataAdapter da;
                da = new SqlDataAdapter(sSel, sCnn);
                da.Fill(dt);
            }
            catch (Exception e) { }
            return dt;

        }

        public static DataTable ObtenerDatosPatologia()

        {
            Conexion con = new Conexion();

            string sCnn = con.conectar();

            string sSel = "select * from V_auditPatologia;";

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



        public static DataTable BuscarPatologia(string accion)

        {
            DataTable dt = new DataTable();
            try

            {
                Conexion c = new Conexion();
                string sCnn = c.conectar();
                string sSel = "select * from V_auditPatologia where accion= '" + accion + "';";
                SqlDataAdapter da;
                da = new SqlDataAdapter(sSel, sCnn);
                da.Fill(dt);
            }
            catch (Exception e) { }
            return dt;

        }

        public static DataTable ObtenerDatosInsumo()

        {
            Conexion con = new Conexion();

            string sCnn = con.conectar();

            string sSel = "select * from V_auditInsumo;";

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



        public static DataTable BuscarInsumo(string accion)

        {
            DataTable dt = new DataTable();
            try

            {
                Conexion c = new Conexion();
                string sCnn = c.conectar();
                string sSel = "select * from V_auditInsumo where accion= '" + accion + "';";
                SqlDataAdapter da;
                da = new SqlDataAdapter(sSel, sCnn);
                da.Fill(dt);
            }
            catch (Exception e) { }
            return dt;

        }

        public static DataTable ObtenerDatosExamen()

        {
            Conexion con = new Conexion();

            string sCnn = con.conectar();

            string sSel = "select * from V_auditExamen;";

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



        public static DataTable BuscarExamen(string accion)

        {
            DataTable dt = new DataTable();
            try

            {
                Conexion c = new Conexion();
                string sCnn = c.conectar();
                string sSel = "select * from V_auditExamen where accion= '" + accion + "';";
                SqlDataAdapter da;
                da = new SqlDataAdapter(sSel, sCnn);
                da.Fill(dt);
            }
            catch (Exception e) { }
            return dt;

        }
        public static DataTable ObtenerDatosFarmaco()

        {
            Conexion con = new Conexion();

            string sCnn = con.conectar();

            string sSel = "select * from V_auditFarmaco;";

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



        public static DataTable BuscarFarmaco(string accion)

        {
            DataTable dt = new DataTable();
            try

            {
                Conexion c = new Conexion();
                string sCnn = c.conectar();
                string sSel = "select * from V_auditFarmaco where accion= '" + accion + "';";
                SqlDataAdapter da;
                da = new SqlDataAdapter(sSel, sCnn);
                da.Fill(dt);
            }
            catch (Exception e) { }
            return dt;

        }

        public static DataTable ObtenerDatosGps()

        {
            Conexion con = new Conexion();

            string sCnn = con.conectar();

            string sSel = "select * from V_auditGPS;";

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



        public static DataTable BuscarGps(string accion)

        {
            DataTable dt = new DataTable();
            try

            {
                Conexion c = new Conexion();
                string sCnn = c.conectar();
                string sSel = "select * from V_auditGPS where accion= '" + accion + "';";
                SqlDataAdapter da;
                da = new SqlDataAdapter(sSel, sCnn);
                da.Fill(dt);
            }
            catch (Exception e) { }
            return dt;

        }
    }
}
