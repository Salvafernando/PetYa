using System;
using System.Collections.Generic;
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
            if (UsuarioDAO.getSW() == 0)
            {
                UsuarioDAO.llenar();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string usuario = TextBoxUsuario.Text;
            string password = TextBoxPassword.Text;

            Usuario user = UsuarioDAO.Login(usuario, password);

            if (user != null)
            {
                Response.Redirect("AgendaPacientes.aspx");
            }
            else 
            {
                LabelError.Text = "Error, usuario o clave no corresponden.";
            }
        }
    }
}