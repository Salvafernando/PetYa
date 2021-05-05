using System;

using System.Collections.Generic;

using System.Linq;

using System.Web;

using System.Web.UI;

using System.Web.UI.WebControls;



namespace Salvador_Hernandez

{

    public partial class VistaAdmin : System.Web.UI.Page

    {

        protected void Page_Load(object sender, EventArgs e)

        {

            Usuario user = (Usuario)Session["Usuario"];

            if (!user.TipoUsuario.Equals("1"))

            {

                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('No tienes acceso a esta pagina, inicie session con las credenciales correspondientes');window.location ='login.aspx'", true);

            }

        }



        protected void ButtonPaciente_Click(object sender, EventArgs e)

        {

            Response.Redirect("CRUDPacientes.aspx");

        }





        protected void ButtonReporteria_Click(object sender, EventArgs e)

        {

            Response.Redirect("Menu_Reporteria.aspx");

        }



        protected void ButtonExamen_Click(object sender, EventArgs e)

        {

            Response.Redirect("CRUDExamen.aspx");

        }



        protected void ButtonFarmaco_Click(object sender, EventArgs e)

        {

            Response.Redirect("CRUDFarmaco.aspx");

        }



        protected void ButtonVacuna_Click(object sender, EventArgs e)

        {

            Response.Redirect("CRUDVacuna.aspx");

        }



        protected void ButtonUsuario_Click(object sender, EventArgs e)

        {

            Response.Redirect("CRUDUsuarios.aspx");

        }



        protected void ButtonInsumo_Click(object sender, EventArgs e)

        {

            Response.Redirect("CRUDInsumo.aspx");

        }



        protected void ButtonPatologia_Click(object sender, EventArgs e)

        {

            Response.Redirect("CRUDPatologia.aspx");

        }

    }

}