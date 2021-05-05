using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Salvador_Hernandez
{
    public partial class AgendaPacientes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonPaciente_Click(object sender, EventArgs e)
        {
            Response.Redirect("CRUDPacientes.aspx");
        }

        protected void ButtonUsuario_Click(object sender, EventArgs e)
        {
            Response.Redirect("CRUDUsuarios.aspx");
        }
    }
}