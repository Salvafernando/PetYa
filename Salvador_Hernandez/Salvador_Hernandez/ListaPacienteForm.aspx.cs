using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Salvador_Hernandez
{
    public partial class ListaPacienteForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (PacienteDAO.getSW() == 0)
            {
                PacienteDAO.llenar();
            }
                GridView1.DataSource = PacienteDAO.ObtenerDatos();
                GridView1.DataBind();
           
           
        
           
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}