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

    public partial class RecuperarContraseña : System.Web.UI.Page

    {

        protected void Page_Load(object sender, EventArgs e)

        {





        }



        protected void Button1_Click(object sender, EventArgs e)

        {



            string Rut = TextBoxRut.Text;

            string Email = TextBoxEmail.Text;

            string PreguntaSecreta = DropDownListPreguntaSecreta.SelectedValue;

            string Respuesta = TextBoxRespuesta.Text;

            string Password = TextBoxPassword.Text;

            string Repassword = TextBoxRepassword.Text;



            if (!Rut.Equals("") && !PreguntaSecreta.Equals("0")

                && !Respuesta.Equals("")

                && !Password.Equals("") && TextBoxPassword.Text == TextBoxRepassword.Text)

            {

                UsuarioDAO.CambiarContraseña(Rut, Password);

                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "Contraseña cambiada correctamente" + "');", true);

                Response.Redirect("Login.aspx");

            }

            else

            {

                LabelOk.Text = "";

                LabelError.Text = "Error, hay campos vacios";

            }

        }



        protected void ButtonEnviar_Click(object sender, EventArgs e)

        {

            string Rut = TextBoxRut.Text;

            string Email = TextBoxEmail.Text;

            if (!Rut.Equals(""))

            {

                string Pregunta = UsuarioDAO.BuscarPregunta(Rut, Email);





                if (Pregunta != null)

                {

                    DropDownListPreguntaSecreta.Enabled = true;

                    TextBoxRespuesta.Enabled = true;

                    ButtonEnviarRespuesta.Enabled = true;



                    if (Pregunta == "1")

                    {

                        DropDownListPreguntaSecreta.SelectedValue = Pregunta;

                    }
                    else if (Pregunta == "2")

                    {

                        DropDownListPreguntaSecreta.SelectedValue = Pregunta;

                    }

                    else if (Pregunta == "3")

                    {

                        DropDownListPreguntaSecreta.SelectedValue = Pregunta;

                    }

                    else if (Pregunta == "4")

                    {

                        DropDownListPreguntaSecreta.SelectedValue = Pregunta;

                    }

                }

                else

                {

                    LabelOk.Text = "";

                    LabelError.Text = "Error, paciente ya existe";

                }

            }

            else

            {

                LabelOk.Text = "";

                LabelError.Text = "Error, hay campos vacios";

            }

        }

        protected void ButtonEnviarRespuesta_Click(object sender, EventArgs e)

        {

            string Respuesta = TextBoxRespuesta.Text;

            string Rut = TextBoxRut.Text;

            string PreguntaSecreta = DropDownListPreguntaSecreta.SelectedValue;



            if (!Respuesta.Equals(""))

            {



                if (UsuarioDAO.VerificarRespuesta(Rut, PreguntaSecreta, Respuesta))

                {

                    ButtonCambiarContraseña.Enabled = true;

                    TextBoxPassword.Enabled = true;

                    TextBoxRepassword.Enabled = true;



                }

                else

                {

                    LabelOk.Text = "";

                    LabelError.Text = "Error, paciente ya existe";

                }

            }

            else

            {

                LabelOk.Text = "";

                LabelError.Text = "Error, hay campos vacios";

            }

        }

    }

}