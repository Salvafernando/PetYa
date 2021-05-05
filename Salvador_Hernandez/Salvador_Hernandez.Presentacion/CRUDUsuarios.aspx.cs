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

    public partial class CRUDUsuarios : System.Web.UI.Page

    {

        protected void Page_Load(object sender, EventArgs e)

        {

            Usuario user = (Usuario)Session["Usuario"];

            if (!user.TipoUsuario.Equals("1"))

            {

                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('No tienes acceso a esta pagina, inicie session con las credenciales correspondientes');window.location ='login.aspx'", true);

            }

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

            string TipoUsuario = DropDownListTipoUsuario.SelectedValue;

            string estado = DropDownListEstado.SelectedValue;

            string Direccion = TextBoxDireccion.Text;

            string Telefono = TextBoxTelefono.Text;

            string Password = TextBoxPassword.Text;

            string Repassword = TextBoxRepassword.Text;





            if (!Rut.Equals("") && Usuario.ValidaRut(Rut) && !PrimerNombre.Equals("") && !SegundoNombre.Equals("")

                && !ApellidoPaterno.Equals("") && !ApellidoMaterno.Equals("")

                && !Email.Equals("")

                && !Respuesta.Equals("") && !TipoUsuario.Equals("0")

                && !Direccion.Equals("") && !Telefono.Equals("")

                && !Password.Equals("") && TextBoxPassword.Text == TextBoxRepassword.Text)

            {

                Usuario user = new Usuario(Rut, PrimerNombre,

                    SegundoNombre, ApellidoPaterno, ApellidoMaterno,

                    Email, PreguntaSecreta, Respuesta,

                    TipoUsuario, estado, Direccion, Telefono, Password);

                if (UsuarioDAO.Agregar(user) == true)

                {

                    ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "Bien, datos agregados correctamente" + "');", true);

                    LabelOk.Text = "Datos agregados correctamente";

                    LabelError.Text = "";

                }

                else

                {

                    LabelOk.Text = "";

                    LabelError.Text = "Error, Usuario ya existe";

                }

            }

            else

            {

                LabelOk.Text = "";

                LabelError.Text = "Error, hay campos vacios";

            }

        }



        protected void ButtonBuscar_Click(object sender, EventArgs e)

        {



            string Rut = TextBoxRut.Text;





            if (!Rut.Equals(""))

            {

                Usuario user = UsuarioDAO.BuscarT(Rut);



                if (user != null)

                {

                    TextBoxRut.Text = user.Rut;

                    TextBoxPrimerNombre.Text = user.PrimerNombre;

                    TextBoxSegundoNombre.Text = user.SegundoNombre;

                    TextBoxApellidoPaterno.Text = user.ApellidoPaterno;

                    TextBoxApellidoMaterno.Text = user.ApellidoMaterno;

                    TextBoxEmail.Text = user.Email;

                    DropDownListPreguntaSecreta.SelectedValue = user.PreguntaSecreta;

                    TextBoxRespuesta.Text = user.RespuestaSecreta;

                    DropDownListTipoUsuario.SelectedValue = user.TipoUsuario;

                    DropDownListEstado.SelectedValue = user.Estado;

                    TextBoxDireccion.Text = user.Direccion;

                    TextBoxTelefono.Text = user.Telefono;

                    LabelOk.Text = "Busqueda exitosa";

                }

                else

                {

                    LabelOk.Text = "";

                    LabelError.Text = "Error, usuario no existe con ese RUT";

                    ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "Error, rut no existe" + "');", true);

                }

            }

        }



        protected void ButtonEliminar_Click(object sender, EventArgs e)

        {



            string Rut = TextBoxRut.Text;

            if (UsuarioDAO.Eliminar(Rut) == true)

            {

                string mensaje = "Bien, datos eliminados";

                LabelError.Text = "";

                LabelOk.Text = "Bien, usuario eliminado.";

                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + mensaje + "');", true);

            }

            else

            {

                LabelOk.Text = "";

                LabelError.Text = "Error, usuario no existe con ese RUT";

            }

        }



        protected void ButtonModificar_Click(object sender, EventArgs e)

        {

            string Rut = TextBoxRut.Text;

            string PrimerNombre = TextBoxPrimerNombre.Text;

            string SegundoNombre = TextBoxSegundoNombre.Text;

            string ApellidoPaterno = TextBoxApellidoPaterno.Text;

            string ApellidoMaterno = TextBoxApellidoMaterno.Text;

            string Email = TextBoxEmail.Text;

            string PreguntaSecreta = DropDownListPreguntaSecreta.SelectedValue;

            string Respuesta = TextBoxRespuesta.Text;

            string TipoUsuario = DropDownListTipoUsuario.SelectedValue;

            string estado = DropDownListEstado.SelectedValue;

            string Direccion = TextBoxDireccion.Text;

            string Telefono = TextBoxTelefono.Text;

            string Password = TextBoxPassword.Text;

            string Repassword = TextBoxRepassword.Text;



            if (!Rut.Equals(""))

            {



                Usuario user = new Usuario(Rut, PrimerNombre,

                    SegundoNombre, ApellidoPaterno, ApellidoMaterno,

                    Email, PreguntaSecreta, Respuesta,

                    TipoUsuario, estado, Direccion, Telefono, Password);



                if (UsuarioDAO.Modificar(user) == true)

                {

                    ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "Bien, datos modificados" + "');", true);

                    LabelOk.Text = "Bien, usuario modificado exitosamente.";

                }

                else

                {

                    LabelOk.Text = "";

                    ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "Error, datos no modificados" + "');", true);

                    LabelError.Text = "Error, usuario no existe con ese RUT";

                }

            }

        }



        protected void Button5_Click(object sender, EventArgs e)

        {

            Response.Redirect("ListaUsuariosForm.aspx");

        }



    }

}