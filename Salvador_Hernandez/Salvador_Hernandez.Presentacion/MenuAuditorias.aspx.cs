using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Salvador_Hernandez.Presentacion
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Usuario user = (Usuario)Session["Usuario"];

            if (!user.TipoUsuario.Equals("1"))

            {

                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('No tienes acceso a esta pagina, inicie session con las credenciales correspondientes');window.location ='login.aspx'", true);

            }
        }

        protected void btnAuditorias_Click(object sender, EventArgs e)

        {

            Response.Redirect("Auditoria.aspx");

        }

        protected void BtnAuditoriaFichas_Click(object sender, EventArgs e)

        {

            Response.Redirect("AuditoriaFichas.aspx");

        }
        protected void BtnAuditoriaVacunas_Click(object sender, EventArgs e)
        {
            Response.Redirect("AuditoriaVacuna.aspx");
        }

        protected void BtnAuditoriaInsumos_Click(object sender, EventArgs e)
        {
            Response.Redirect("AuditoriaInsumo.aspx");
        }

        protected void BtnAuditoriaExamen_Click(object sender, EventArgs e)
        {
            Response.Redirect("AuditoriaExamen.aspx");
        }

        protected void BtnAuditoriaGps_Click(object sender, EventArgs e)
        {
            Response.Redirect("AuditoriaGps.aspx");
        }

        protected void BtnAuditoriaFarmaco_Click(object sender, EventArgs e)
        {
            Response.Redirect("AuditoriaFarmaco.aspx");
        }

        protected void BtnAuditoriaReserva_Click(object sender, EventArgs e)
        {
            Response.Redirect("AuditoriaReserva.aspx");
        }

        protected void BtnAuditoriaPatologia_Click(object sender, EventArgs e)
        {
            Response.Redirect("AuditoriaPatologia.aspx");
        }
    }
}