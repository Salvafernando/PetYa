using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Salvador_Hernandez
{
    public partial class VistaVeterinario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Usuario user = (Usuario)Session["Usuario"];

            if (!user.TipoUsuario.Equals("2"))

            {

                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('No tienes acceso a esta pagina, inicie session con las credenciales correspondientes');window.location ='login.aspx'", true);

            }
        }

        protected void ButtonFichasMedicas_Click(object sender, EventArgs e)
        {
            Response.Redirect("FichaMascotaVet.aspx");
        }

        protected void ButtonIngresarMascota_Click(object sender, EventArgs e)
        {
            Response.Redirect("CRUDMascota.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("AtencionMascota.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("BusquedaInfoVet.aspx");
        }
    }
}