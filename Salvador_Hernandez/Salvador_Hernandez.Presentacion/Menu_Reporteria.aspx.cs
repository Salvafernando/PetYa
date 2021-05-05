using System;

using System.Collections.Generic;

using System.Linq;

using System.Web;

using System.Web.UI;

using System.Web.UI.WebControls;



namespace Salvador_Hernandez.Presentacion

{

    public partial class Menu_Reporteria : System.Web.UI.Page

    {

        protected void Page_Load(object sender, EventArgs e)

        {

            Usuario user = (Usuario)Session["Usuario"];

            if (!user.TipoUsuario.Equals("1"))

            {

                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('No tienes acceso a esta pagina, inicie session con las credenciales correspondientes');window.location ='login.aspx'", true);

            }

        }



        protected void btnUsuarios_Click(object sender, EventArgs e)

        {

            Response.Redirect("ListarUsuarios.aspx");

        }







        protected void btnMascotas_Click(object sender, EventArgs e)

        {

            Response.Redirect("ListarMascota.aspx");

        }







        protected void btnTrabajadores_Click(object sender, EventArgs e)

        {

            Response.Redirect("ListarTrabajadores.aspx");

        }

        protected void btnAuditorias_Click(object sender, EventArgs e)

        {

            Response.Redirect("Auditoria.aspx");

        }

        protected void BtnAuditoriaFichas_Click(object sender, EventArgs e)

        {

            Response.Redirect("AuditoriaFichas.aspx");

        }

    }

}