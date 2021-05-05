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

    public partial class Login : System.Web.UI.Page

    {

        protected void Page_Load(object sender, EventArgs e)

        {

            Usuario user = new Usuario("", "", "", "", "", "", "", "", "", "", "", "", "");

            Session["Usuario"] = user;

        }



        protected void Button1_Click(object sender, EventArgs e)

        {

            string usuario = TextBoxUsuario.Text;

            string password = TextBoxPassword.Text;



            Usuario user = UsuarioDAO.Login(usuario, password);

            Session["Usuario"] = user;



            if (user != null)

            {

                if (user.TipoUsuario == "1")

                {

                    Response.Redirect("VistaAdmin.aspx");

                }

                else if (user.TipoUsuario == "2")

                {

                    Response.Redirect("VistaVeterinario.aspx");

                }

                else if (user.TipoUsuario == "3")

                {

                    Response.Redirect("VistaCliente.aspx");

                }

                else

                {

                    LabelError.Text = "Error, usuario no tiene los permisos de acceso.";

                }

            }

            else

            {

                LabelError.Text = "Error, usuario o clave no corresponden.";

            }

        }



        protected void Button2_Click(object sender, EventArgs e)

        {

            Response.Redirect("CRUDCliente.aspx");

        }

        protected void TextBoxUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }

}