using Salvador_Hernandez.AccesoDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Salvador_Hernandez
{
    public partial class CRUDCliente : System.Web.UI.Page

    {

        protected void Page_Load(object sender, EventArgs e)

        {

            Usuario user = new Usuario("", "", "", "", "", "", "", "", "", "", "", "", "");

            Session["Usuario"] = user;

        }



        protected void Button1_Click(object sender, EventArgs e)

        {



            string Rut = TextBoxRut.Text;

            string PrimerNombre = TextBoxPrimerNombre.Text;

            string SegundoNombre = TextBoxSegundoNombre.Text;

            string ApellidoPaterno = TextBoxApellidoPaterno.Text;

            string ApellidoMaterno = TextBoxApellidoMaterno.Text;

            string Email = TextBoxEmail.Text;

            string PreguntaSecreta = DropDownListPreguntaSecreta.SelectedValue;

            string Respuesta = TextBoxRespuesta.Text;

            string TipoUsuario = "3";

            string Direccion = TextBoxDireccion.Text;

            string Telefono = TextBoxTelefono.Text;

            string Password = TextBoxPassword.Text;

            string Repassword = TextBoxRepassword.Text;

            string Estado = null;







            if (!Rut.Equals("") && Usuario.ValidaRut(Rut) && !PrimerNombre.Equals("") && !SegundoNombre.Equals("")

                && !ApellidoPaterno.Equals("") && !ApellidoMaterno.Equals("")

                && !Email.Equals("") && !PreguntaSecreta.Equals("0")

                && !Respuesta.Equals("") && !TipoUsuario.Equals("")

                && !Direccion.Equals("") && !Telefono.Equals("")

                && !Password.Equals("") && TextBoxPassword.Text == TextBoxRepassword.Text)

            {

                Usuario user = new Usuario(Rut, PrimerNombre,

                   SegundoNombre, ApellidoPaterno, ApellidoMaterno,

                   Email, PreguntaSecreta, Respuesta,

                   TipoUsuario, Estado, Direccion, Telefono, Password);

                if (UsuarioDAO.Agregar(user) == true)

                {

                    Response.Write("Hola1");

                    ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "Bien, datos agregados correctamente" + "');", true);

                    LabelOk.Text = "Datos agregados correctamente";

                    LabelError.Text = "";

                    Response.Redirect("Login.aspx");

                }

                else

                {



                    LabelOk.Text = "";

                    LabelError.Text = "Error, Usuario ya existe";

                }

            }

            else

            {

                Response.Write("Hola3");



                LabelOk.Text = "";

                LabelError.Text = "Error, hay campos vacios";

            }

        }





    }
}