using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Salvador_Hernandez
{
    public partial class VistaCliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Usuario user = (Usuario)Session["Usuario"];

            if (!user.TipoUsuario.Equals("3"))

            {

                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('No tienes acceso a esta pagina, inicie session con las credenciales correspondientes');window.location ='login.aspx'", true);

            }
        }

        protected void ButtonAgendar_Click(object sender, EventArgs e)
        {
            Response.Redirect("PaginaEnConstruccion3.aspx");
        }

        protected void ButtonMiMascota_Click(object sender, EventArgs e)
        {
            Response.Redirect("FichaMascota.aspx");
        }
    }
}