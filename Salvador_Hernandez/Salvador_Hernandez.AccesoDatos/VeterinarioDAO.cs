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
            string sSel = "Select RUT_VET,NOMBRE_VET,PRI_APELLIDO_VET,SEC_APPELLIDO_VET," +
                "FONO_VET,EMAIL_VET,ID_ROL,ID_PERFIL from VETERINARIO";
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
        public static DataTable ObtenerDatosVet()
        {
            Conexion con = new Conexion();
            string sCnn = con.conectar();
            string sSel = "Select concat(PRI_NOMBRE,' ',APELLIDO_P,' ',APELLIDO_M) NombreVet, RUT_USUARIO from usuarios where rut_usuario in ( select distinct(th.RUT_VET) from tabla_horario_vet th  inner join tabla_fechas tf on (th.ID_DIA= tf.ID_FECHA) inner join horario h on (th.ID_HORA=h.ID_HORARIO) where th.ESTADO_HORA='L')";
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
        public static DataTable BuscarHorario(string rut)
        {
            DataTable dt = new DataTable();
            try
            {
                Conexion c = new Conexion();
                string sCnn = c.conectar();

                string sSel = "select distinct(format(tf.DIA,'yyyy-MM-dd')) horario from tabla_horario_vet th " +
                    " inner join tabla_fechas tf on (th.ID_DIA= tf.ID_FECHA) " +
                    " inner join horario h on (th.ID_HORA=h.ID_HORARIO) " +
                    " where th.ESTADO_HORA ='L' and tf.DIA>=getdate()" +
                    "and th.RUT_VET in" +
                    " (select rut_usuario from usuarios where concat(PRI_NOMBRE,' ',APELLIDO_P,' ',APELLIDO_M) ='"+rut+"') " +
                    " order by horario";
                SqlDataAdapter da;


                da = new SqlDataAdapter(sSel, sCnn);
                da.Fill(dt);



            }
            catch (Exception e) { }

            return dt;
        }
        public static DataTable BuscarHora(string rut,string fecha)
        {
            DataTable dt = new DataTable();
            try
            {
                Conexion c = new Conexion();
                string sCnn = c.conectar();

                string sSel = "select h.HORA  hora  from tabla_horario_vet th " +
                    " inner join tabla_fechas tf on (th.ID_DIA= tf.ID_FECHA) " +
                    " inner join horario h on (th.ID_HORA=h.ID_HORARIO) " +
                    " where th.ESTADO_HORA ='L' " +
                    "and th.RUT_VET in" +
                    " (select rut_usuario from usuarios " +
                    "where concat(PRI_NOMBRE,' ',APELLIDO_P,' ',APELLIDO_M) ='" + rut + "') " +
                    "and tf.DIA= '"+fecha+"'" +
                    " order by hora";
                SqlDataAdapter da;


                da = new SqlDataAdapter(sSel, sCnn);
                da.Fill(dt);



            }
            catch (Exception e) { }

            return dt;
        }
        public static DataTable BuscarReserva(string rut)
        {
            DataTable dt = new DataTable();
            try
            {
                Conexion c = new Conexion();
                string sCnn = c.conectar();

                string sSel = "select r.ID_RESERVA Reserva, tf.DIA Dia, h.HORA Hora from reserva r " +
                    "inner join USUARIOS u on (r.ID_PROFESIONAL = u.RUT_USUARIO) " +
                    "inner join TABLA_HORARIO_VET th on (r.ID_HORARIO = th.ID_HORARIO_VET)" +
                    " inner join HORARIO h on (th.ID_HORA =h.ID_HORARIO) " +
                    "inner join TABLA_FECHAS tf on (th.ID_DIA = tf.ID_FECHA) " +
                    "where R.RUT_DUENO='"+rut+"' and r.Estado='A'";
                SqlDataAdapter da;


                da = new SqlDataAdapter(sSel, sCnn);
                da.Fill(dt);



            }
            catch (Exception e) { }

            return dt;
        }
        public static DataTable EliminarReserva(string id)
        {
            DataTable dt = new DataTable();
            try
            {
                Conexion c = new Conexion();
                string sCnn = c.conectar();

                string sSel = "update reserva set estado='I' where ID_RESERVA ="+id+"";
                SqlDataAdapter da;


                da = new SqlDataAdapter(sSel, sCnn);
                da.Fill(dt);



            }
            catch (Exception e) { }

            return dt;
        }
        public static DataTable ActualizaVetTH(string id)
        {
            DataTable dt = new DataTable();
            try
            {
                Conexion c = new Conexion();
                string sCnn = c.conectar();

                string sSel = "update TABLA_HORARIO_VET set Estado ='L' " +
                    "where ID_HORARIO_VET = (select ID_HORARIO FROM RESERVA WHERE ID_RESERVA="+id+")";
                SqlDataAdapter da;


                da = new SqlDataAdapter(sSel, sCnn);
                da.Fill(dt);



            }
            catch (Exception e) { }

            return dt;
        }
        public static DataTable BuscarIdReserva(string rut, string fecha, string hora)
        {
            DataTable dt = new DataTable();
            try
            {
                Conexion c = new Conexion();
                string sCnn = c.conectar();

                string sSel = "select th.ID_HORARIO_VET hora  from tabla_horario_vet th " +
                    " inner join tabla_fechas tf on (th.ID_DIA= tf.ID_FECHA) " +
                    " inner join horario h on (th.ID_HORA=h.ID_HORARIO) " +
                    " where th.ESTADO_HORA ='L' " +
                    "and th.RUT_VET in" +
                    " (select rut_usuario from usuarios " +
                    "where concat(PRI_NOMBRE,' ',APELLIDO_P,' ',APELLIDO_M) ='" + rut + "') " +
                    "and tf.DIA= '" + fecha + "' and h.hora='" + hora + "'";
                SqlDataAdapter da;


                da = new SqlDataAdapter(sSel, sCnn);
                da.Fill(dt);



            }
            catch (Exception e) { }

            return dt;
        }
        public static DataTable ActualizaEstadoVetH(string id)
        {
            DataTable dt = new DataTable();
            try
            {
                Conexion c = new Conexion();
                string sCnn = c.conectar();

                string sSel = "update TABLA_HORARIO_VET set ESTADO_HORA='R' where ID_HORARIO_VET0="+id+"";
                SqlDataAdapter da;


                da = new SqlDataAdapter(sSel, sCnn);
                da.Fill(dt);



            }
            catch (Exception e) { }

            return dt;
        }
        public static DataTable ActualizaReserva(string rutDueno, string id, string rut)
        {
            DataTable dt = new DataTable();
            try
            {
                Conexion c = new Conexion();
                string sCnn = c.conectar();

                string sSel = "insert into reserva (RUT_DUENO, ID_PROFESIONAL, ID_HORARIO, ESTADO)" +
                    " values ('"+rutDueno+"', (select rut_usuario from usuarios where " +
                    "concat(PRI_NOMBRE,' ',APELLIDO_P,' ',APELLIDO_M) ='"+rut+"'),"+id+",'A')";
                SqlDataAdapter da;


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
