using Salvador_Hernandez.AccesoDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Salvador_Hernandez
{
    public class PacienteDAO
    {
        private static List<Paciente> alPaciente = new List<Paciente>();
        private static int sw = 0;


        public static int getSW()
        {
            return sw;
        }


        public static DataTable ObtenerDatos()
        {
            Conexion con = new Conexion();
            string sCnn = con.conectar();
            string sSel = "Select * from TblPaciente";
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

        public static DataTable Agregar(string NombreMascota, string Raza, DateTime fecha, string Genero, string Foto, string RutDueno )
        {
            DataTable dt = new DataTable();
            string sCnn;
            try
            {
                Conexion c = new Conexion();
                sCnn = c.conectar();

                string sSel = "insert into TblPaciente (nombreMascota, raza, f_nacimiento, genero, foto, id_dueno) values(" +
                    NombreMascota + ",'" + Raza + "'," + fecha  + ",'" + Genero +
                    "','" + Foto + "','" + RutDueno+"');";
                SqlDataAdapter da;
                da = new SqlDataAdapter(sSel, sCnn);
                da.Fill(dt);
            }
            catch (Exception e)
            {
           
            }
            return dt;
        }

        public static Paciente Buscar(int Id)
        {
           Paciente obj = null;
           try
            {
                Conexion c = new Conexion();
                string sCnn = c.conectar();

                string sSel1 = "Select  * from TblPaciente where id=" + Id + "";
                SqlDataAdapter da1;
                DataTable dt1 = new DataTable();

                da1 = new SqlDataAdapter(sSel1, sCnn);
                da1.Fill(dt1);
                obj = new Paciente(Id, dt1.Rows[0][1].ToString(), dt1.Rows[0][7].ToString(),DateTime.Parse(dt1.Rows[0][2].ToString()), dt1.Rows[0][4].ToString(), dt1.Rows[0][4].ToString(), dt1.Rows[0][5].ToString(), dt1.Rows[0][6].ToString());
               
            }
            catch(Exception e){ }

            return obj;
        }

        public static Boolean Eliminar(int id)
        {
            Boolean estado = true;
            try
            {
                Conexion c = new Conexion();
                string sCnn = c.conectar();

                string sSel = "delete from TblPaciente where id =" + id + ";";
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

        public static Boolean Modificar(Paciente paciente)
        {
            Boolean estado = true;
            try
            {
                Conexion c = new Conexion();
                string sCnn = c.conectar();

                string sSel = "update TblPaciente set nombreMascota ='" + paciente.nombreMascota +
                    "',fechaNac='" + paciente.fechaNac + "',genero='" + paciente.genero +
                    "',foto='"+paciente.foto+"',rutDueno='"+paciente.rutDueno+"',nombreDueno='"+
                    paciente.nombreDueno+"',raza='"+paciente.raza+"' where id=" +
                    paciente.id + ";";
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