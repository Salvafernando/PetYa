using Salvador_Hernandez.AccesoDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Configuration;
using System.Security.Cryptography;
using System.IO;
using System.Text;
using System.Web;

namespace Salvador_Hernandez
{
   public class UsuarioDAO
    {
        private static List<Usuario> alUsuarios = new List<Usuario>();
        private static int sw = 0;

        public static int getSW() 
        {
            return sw;
        }

      

        public static DataTable ObtenerDatos()
        {
            Conexion con = new Conexion();
            string sCnn = con.conectar();
            string sSel = "Select * from USUARIOS";
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

        
        public static string BuscarUsuario(string rut)
        {
            string obj = null;
            try
            {
                Conexion c = new Conexion();
                string sCnn = c.conectar();

                string sSel = "Select * from USUARIOS where RUT_USUARIO = '" + rut + "';";
                SqlDataAdapter da;
                DataTable dt = new DataTable();

                da = new SqlDataAdapter(sSel, sCnn);
                da.Fill(dt);
                obj = dt.Rows[0][0].ToString();
            }
            catch (Exception e) { }

            return obj;


        }

        public static DataTable BuscarMascota(string rut)
        {
          // string obj = null;
            DataTable dt = new DataTable();

            try
            {

                Conexion con = new Conexion();
                string sCnn = con.conectar();
                string sSel = "Select * from ficha_mascota where id_dueno = '" + rut + "';";
                SqlDataAdapter da;
             
                da = new SqlDataAdapter(sSel, sCnn);
                da.Fill(dt);
             //   obj = dt.Rows[0][0].ToString();
            }
            catch (Exception e) { }

            return dt;

        }


        private static string Encrypt(string clearText)
        {
            string EncryptionKey = "MAKV2SPBNI99212";
            byte[] clearBytes = Encoding.Unicode.GetBytes(clearText);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(clearBytes, 0, clearBytes.Length);
                        cs.Close();
                    }
                    clearText = Convert.ToBase64String(ms.ToArray());
                }
            }
            return clearText;
        }

        private static string Decrypt(string cipherText)
        {
            string EncryptionKey = "MAKV2SPBNI99212";
            byte[] cipherBytes = Convert.FromBase64String(cipherText);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(cipherBytes, 0, cipherBytes.Length);
                        cs.Close();
                    }
                    cipherText = Encoding.Unicode.GetString(ms.ToArray());
                }
            }
            return cipherText;
        }

        public static Boolean Agregar(Usuario usuario)
        {
            
            Boolean estado = true;
            string sCnn;
            try
            {
                Conexion c = new Conexion();
                sCnn = c.conectar();

                string sSel = "insert into USUARIOS (RUT_USUARIO, PRI_NOMBRE, SEG_NOMBRE, APELLIDO_P, APELLIDO_M, F_CREACION, EMAIL, PREG_SECRETA, RESP_SECRETA, ID_PERFIL, ESTADO, DIRECCION, TELEFONO, PASSWORD) values('"
                              + usuario.Rut
                              + "','"
                              + usuario.PrimerNombre
                              + "','"
                              + usuario.SegundoNombre
                              + "','"
                              + usuario.ApellidoPaterno
                              + "','"
                              + usuario.ApellidoMaterno
                              + "',"
                              + "SYSDATETIME()"
                              + ",'"
                              + usuario.Email
                              + "','"
                              + usuario.PreguntaSecreta
                              + "','"
                              + usuario.RespuestaSecreta
                              + "',"
                              + usuario.TipoUsuario
                              + ",'"
                              + "Activo"
                              + "','"
                              + usuario.Direccion
                              + "','"
                              + usuario.Telefono
                              + "','"
                              + Encrypt(usuario.Password)
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

        public static Usuario BuscarT(string rut)

        {

            Usuario obj = null;

            try

            {

                Conexion c = new Conexion();

                string sCnn = c.conectar();



                string sSel = "Select RUT_USUARIO,PRI_NOMBRE,SEG_NOMBRE,APELLIDO_P,APELLIDO_M,EMAIL, PREG_SECRETA, RESP_SECRETA,ID_PERFIL,ESTADO,DIRECCION,TELEFONO,PASSWORD from USUARIOS where RUT_USUARIO = '" + rut + "';";

                SqlDataAdapter da;

                DataTable dt = new DataTable();



                da = new SqlDataAdapter(sSel, sCnn);

                da.Fill(dt);

                obj = new Usuario(rut, dt.Rows[0][1].ToString()

                    , dt.Rows[0][2].ToString(), dt.Rows[0][3].ToString()

                    , dt.Rows[0][4].ToString(), dt.Rows[0][5].ToString()

                    , dt.Rows[0][6].ToString(), dt.Rows[0][7].ToString()

                    , dt.Rows[0][8].ToString(), dt.Rows[0][9].ToString()

                    , dt.Rows[0][10].ToString(), dt.Rows[0][11].ToString()

                    , dt.Rows[0][12].ToString());





            }

            catch (Exception e) { }



            return obj;

        }

        public static DataTable Buscar(string rut)
        {
            DataTable dt = new DataTable();
            try
            {
                Conexion c = new Conexion();
                string sCnn = c.conectar();

                string sSel = "Select RUT_USUARIO,PRI_NOMBRE,APELLIDO_P,F_CREACION,EMAIL,ID_PERFIL,ESTADO,DIRECCION,TELEFONO from USUARIOS where RUT_USUARIO = '" + rut + "';";
                SqlDataAdapter da;


                da = new SqlDataAdapter(sSel, sCnn);
                da.Fill(dt);



            }
            catch (Exception e) { }

            return dt;
        }

        public static string BuscarPregunta(string rut, string email)
        {
            string obj = null;
            try
            {
                Conexion c = new Conexion();
                string sCnn = c.conectar();

                string sSel = "Select PREG_SECRETA from USUARIOS where RUT_USUARIO = '" + rut + "' AND EMAIL = '" + email + "';";
                SqlDataAdapter da;
                DataTable dt = new DataTable();

                da = new SqlDataAdapter(sSel, sCnn);
                da.Fill(dt);
                obj = dt.Rows[0][0].ToString();
            }
            catch (Exception e) { }

            return obj;
        }




        public static Boolean VerificarRespuesta(string rut, string pregunta, string respuesta)
        {
            Boolean estado = true;
            string respuestaCorrecta = null;
            try
            {
                Conexion c = new Conexion();
                string sCnn = c.conectar();

                string sSel = "Select RESP_SECRETA from USUARIOS where RUT_USUARIO = '" + rut + "' AND PREG_SECRETA = '" + pregunta + "' ;";
                SqlDataAdapter da;
                DataTable dt = new DataTable();

                da = new SqlDataAdapter(sSel, sCnn);
                da.Fill(dt);
                respuestaCorrecta = dt.Rows[0][0].ToString();
                if (respuesta == respuestaCorrecta)
                {
                    estado = true;
                }
                else
                {
                    estado = false;
                }

            }
            catch (Exception e) 
            {
                estado = false;
            }

            return estado;
        }

        public static Boolean CambiarContraseña(string rut ,string password)
        {
            Boolean estado = true;
            try
            {
                Conexion c = new Conexion();
                string sCnn = c.conectar();

                string sSel = "update USUARIOS set PASSWORD ='" + Encrypt(password) + "' where RUT_USUARIO='" +
                    rut + "';";
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

        public static Usuario Login(string rut,string password)
        {
            Usuario obj = null;
            try
            {
                Conexion c = new Conexion();
                string sCnn = c.conectar();

                string sSel = "Select RUT_USUARIO, PRI_NOMBRE, SEG_NOMBRE, APELLIDO_P, APELLIDO_M," +
                    " EMAIL, PREG_SECRETA, RESP_SECRETA, ID_PERFIL,Estado, DIRECCION, TELEFONO  from USUARIOS where RUT_USUARIO = '" + rut + "' and PASSWORD='"+Encrypt(password)+"';";
                SqlDataAdapter da;
                DataTable dt = new DataTable();

                da = new SqlDataAdapter(sSel, sCnn);
                da.Fill(dt);
                obj = new Usuario(rut, dt.Rows[0][1].ToString(), dt.Rows[0][2].ToString()
                    , dt.Rows[0][3].ToString(), dt.Rows[0][4].ToString()
                    , dt.Rows[0][5].ToString(), dt.Rows[0][6].ToString()
                    , dt.Rows[0][7].ToString(), dt.Rows[0][8].ToString()
                    , dt.Rows[0][9].ToString(), dt.Rows[0][10].ToString(), dt.Rows[0][11].ToString(), password);
            }
            catch (Exception e) { }

            return obj;
        }
        
        public static Boolean Eliminar(string rut)
        {
            Boolean estado = true;
            try
            {
                Conexion c = new Conexion();
                string sCnn = c.conectar();

                string sSel = "delete from USUARIOS where RUT_USUARIO ='" + rut + "';";
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

        public static Boolean Modificar(Usuario usuario)

        {

            Boolean estado = true;

            try

            {

                Conexion c = new Conexion();

                string sCnn = c.conectar();



                string sSel = "update USUARIOS set PRI_NOMBRE ='" + usuario.PrimerNombre +

                    "',SEG_NOMBRE='" + usuario.SegundoNombre + "',APELLIDO_P='" + usuario.ApellidoPaterno +

                    "',APELLIDO_M='" + usuario.ApellidoMaterno + "',EMAIL='" + usuario.Email +

                    "',PREG_SECRETA='" + usuario.PreguntaSecreta + "',RESP_SECRETA='" + usuario.RespuestaSecreta +

                    "',ID_PERFIL='" + usuario.TipoUsuario + "',ESTADO='" + usuario.Estado + "',DIRECCION='" + usuario.Direccion +

                    "',TELEFONO='" + usuario.Telefono + "' where RUT_USUARIO='" + usuario.Rut + "';";

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