using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salvador_Hernandez.AccesoDatos
{
    public class MascotaDAO
    {
        public static DataTable ObtenerDatos()
    {
        Conexion con = new Conexion();
        string sCnn = con.conectar();
        string sSel = "Select ID_FICHA,ID_DUENO,NOMBRE,RAZA,F_CREACION,ESPECIE,SEXO,PELAJE,F_NACIMIENTO,ESTADO,FOTO from FICHA_MASCOTA";
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
    public static DataTable Buscar(string ID)
    {
        DataTable dt = new DataTable();
        try
        {
            Conexion c = new Conexion();
            string sCnn = c.conectar();

            string sSel = "Select ID_FICHA,ID_DUENO,NOMBRE,RAZA,F_CREACION,ESPECIE,SEXO,F_NACIMIENTO,ESTADO,FOTO from FICHA_MASCOTA where ID_DUENO = '" + ID + "';";
            SqlDataAdapter da;


            da = new SqlDataAdapter(sSel, sCnn);
            da.Fill(dt);



        }
        catch (Exception e) { }

        return dt;
    }

        public static DataTable BuscarInfoVet(string ID)
        {
            DataTable dt = new DataTable();
            try
            {
                Conexion c = new Conexion();
                string sCnn = c.conectar();

                string sSel = "select ANAMNESIS,DIAGNOSTICO,TRATAMIENTO,OBSERVACIONES from ATENCION_MASCOTA where DIAGNOSTICO like '%"+ID+"%' " +
                    "or ANAMNESIS like '%" + ID + "%'  or TRATAMIENTO like '%" + ID + "%'  or OBSERVACIONES like '%" + ID + "%' ";
                SqlDataAdapter da;


                da = new SqlDataAdapter(sSel, sCnn);
                da.Fill(dt);



            }
            catch (Exception e) { }

            return dt;
        }



        public static DataTable BuscarFicha(string nombre, string rut)
        {
            DataTable dt = new DataTable();

            try
            {

                Conexion con = new Conexion();
                string sCnn = con.conectar();

                string sSel1 = "select fc.nombre," +
                    "fc.raza," +
                    "fc.especie," +
                    "fc.sexo," +
                    "fc.f_nacimiento," +
                    "am.peso," +
                    "am.temperatura," +
                    "am.frec_cardiaca, " +
                    "am.frec_respiratoria," +
                    "am.ANAMneSIS," +
                    "am.signos_clinicos," +
                    "am.prediagnostico," +
                    "am.diagnostico," +
                    "am.pronostico," +
                    "am.tratamiento," +
                    "am.observaciones " +
                    " from FICHA_MASCOTA fc " +
                    "inner join ATENCION_MASCOTA am on" +
                    "(fc.id_ficha = am.id_ficha)" +
                    "inner join usuarios u on " +
                    "(fc.id_dueno = u.RUT_USUARIO) " +
                    "where u.RUT_USUARIO = '" + rut + "' and fc.NOMBRE = '" + nombre + "'; ";
                SqlDataAdapter da;

                da = new SqlDataAdapter(sSel1, sCnn);
                da.Fill(dt);
              
            }
            catch (Exception e) { }

            return dt;
        }
        public static DataTable Agregar(string NombreMascota, string Raza, DateTime fecha, string Genero, string Foto, string RutDueno,string Especie)
        {
            DataTable dt = new DataTable();
            string sCnn;
            try
            {
                Conexion c = new Conexion();
                sCnn = c.conectar();

                string sSel = "insert into ficha_mascota (nombre, raza, f_nacimiento, f_creacion, SEXO, foto, id_dueno, estado, especie) values('" +
                     NombreMascota + "','" + Raza + "', sysdatetime(), sysdatetime(),'" + Genero +
                     "','" + Foto + "','" + RutDueno + "','Activo','" + Especie + "');";
                SqlDataAdapter da;
                da = new SqlDataAdapter(sSel, sCnn);
                da.Fill(dt);
            }
            catch (Exception e)
            {

            }
            return dt;
        }
        public static DataTable ModificarMascota(string NombreMascota, string Raza, DateTime fecha, string Genero, string Foto, string RutDueno, string Especie)
        {
            DataTable dt = new DataTable();
            string sCnn;
            try
            {
                Conexion c = new Conexion();
                sCnn = c.conectar();

                string sSel = "update ficha_mascota set nombre='"+NombreMascota+"',raza='"+Raza+"',sexo='"+Genero+"'," +
                    "foto='"+Foto+"', especie='"+Especie+"' where nombre='"+NombreMascota+"' and id_dueno='"+RutDueno+"'";
                SqlDataAdapter da;
                da = new SqlDataAdapter(sSel, sCnn);
                da.Fill(dt);
            }
            catch (Exception e)
            {

            }
            return dt;
        }

        public static DataTable EliminarMascota(string NombreMascota, string RutDueno)
        {
            DataTable dt = new DataTable();
            string sCnn;
            try
            {
                Conexion c = new Conexion();
                sCnn = c.conectar();

                string sSel = "update ficha_mascota set estado='Inactivo' where nombre='" +
                    NombreMascota + "' and id_dueno ='"+RutDueno+"';";
                SqlDataAdapter da;
                da = new SqlDataAdapter(sSel, sCnn);
                da.Fill(dt);
            }
            catch (Exception e)
            {

            }
            return dt;
        }

        public static Boolean Eliminar(string ID)
    {
        Boolean estado = true;
        try
        {
            Conexion c = new Conexion();
            string sCnn = c.conectar();

            string sSel = "Delete from FICHA_MASCOTA where ID_FICHA = '" + ID + "';";
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
        public static DataTable ActualizarFicha(string nombre, string rut,int peso,int temperatura,int frec_cardiaca, int frec_respiratoria,
            string anamnesis, string svitale,string pdiagnostico, string diagnostico, string pronostico, string tramiento, string observaciones)
        {
            DataTable dt = new DataTable();

            try
            {

                Conexion con = new Conexion();
                string sCnn = con.conectar();

                string sSel1 = "if exists " +
                    "(select * from FICHA_MASCOTA fc inner join ATENCION_MASCOTA am on " +
                    "(fc.id_ficha = am.id_ficha) inner join usuarios u on " +
                    "(fc.id_dueno = u.RUT_USUARIO)  where u.RUT_USUARIO = '"+rut+"' and fc.NOMBRE = '"+nombre+"') " +
                    "begin " +
                    "update ATENCION_MASCOTA " +
                    "set peso="+peso+"," +
                    "TEMPERATURA=" + temperatura + "," +
                    " FREC_CARDIACA=" + frec_cardiaca + "," +
                    "FREC_RESPIRATORIA=" + frec_respiratoria + "," +
                    " ANAMNESIS='"+anamnesis+"'," +
                    " SIGNOS_CLINICOS='" + svitale + "'," +
                    " PREDIAGNOSTICo='" + pdiagnostico + "'," +
                    "DIAGNOSTICO='" + diagnostico + "'," +
                    " PRONOSTICO='" + pronostico + "'," +
                    " TRATAMIENTO='" + tramiento + "'," +
                    " OBSERVACIONES='" + observaciones + "'" +
                    "where  ID_FICHA=(select f.id_ficha from FICHA_MASCOTA f where f.ID_DUENO = '" + rut + "'  and f.NOMBRE = '" + nombre + "');" +
                    "end" +
                    " else" +
                    " begin" +
                    " insert into ATENCION_MASCOTA (id_ficha, rut_vet,peso, TEMPERATURA, " +
                    "FREC_CARDIACA,FREC_RESPIRATORIA, ANAMNESIS, SIGNOS_CLINICOS, " +
                    "PREDIAGNOSTICO, DIAGNOSTICO, PRONOSTICO," +
                    "TRATAMIENTO,OBSERVACIONES ) values" +
                    " ((select f.id_ficha from FICHA_MASCOTA f where f.ID_DUENO = '" + rut + "' and f.NOMBRE = '" + nombre + "')," +
                    " '16264652-4'," +
                    " "+peso+"," +
                    " " + temperatura + "," +
                    " " + frec_cardiaca + "," +
                    " " + frec_respiratoria + "," +
                    "'"+anamnesis+"'," +
                   "'" + svitale + "'," +
                    "'" + pdiagnostico + "'," +
                   "'" + diagnostico + "'," +
                   "'" + pronostico + "'," +
                    "'" + tramiento + "'," +
                    "'"+observaciones+"') " +
                    "end";
                SqlDataAdapter da;

                da = new SqlDataAdapter(sSel1, sCnn);
                da.Fill(dt);
                //   obj = dt.Rows[0][0].ToString();
            }
            catch (Exception e) { }

            return dt;
        }

    }
}
