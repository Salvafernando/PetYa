using Salvador_Hernandez.AccesoDatos;

using System;

using System.Collections.Generic;

using System.Data;

using System.Linq;

using System.Web;

using System.Web.UI;

using System.Web.UI.WebControls;



namespace Salvador_Hernandez.Presentacion

{

    public partial class ListaPatologia : System.Web.UI.Page

    {

        protected void Page_Load(object sender, EventArgs e)

        {

            Usuario user = (Usuario)Session["Usuario"];

            if (!user.TipoUsuario.Equals("1"))

            {

                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('No tienes acceso a esta pagina, inicie session con las credenciales correspondientes');window.location ='login.aspx'", true);

            }

            listar();



        }



        public void listar()

        {

            DataTable dt = PatologiaDAO.ObtenerDatos();

            GridView1.DataSource = dt;

            GridView1.DataBind();





        }



        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)

        {



        }

    }

}