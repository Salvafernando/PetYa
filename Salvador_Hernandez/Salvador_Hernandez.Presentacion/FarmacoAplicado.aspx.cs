using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Salvador_Hernandez.Presentacion
{
    public partial class FarmacoAplicado : System.Web.UI.Page
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
            DataTable dt = Salvador_Hernandez.AccesoDatos.Reporterias.ObtenerDatosFarmacosapli();
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)

        {
        }

        protected void BtnBuscar_Click(object sender, EventArgs e)

        {

            string id = txtId.Text;
            if (!id.Equals(""))

            {
                try

                {

                    DataTable dt = Salvador_Hernandez.AccesoDatos.Reporterias.BuscarFarmacos(id);



                    GridView1.DataSource = dt;

                    GridView1.DataBind();

                    if (dt.Rows[0]["ID_DUENO"].ToString().Equals(id))

                    {
                    }
                    LabelOk.Text = "Farmacos encontrados por Rut";

                    LabelError.Text = "";

                }

                catch (IndexOutOfRangeException)

                {

                    LabelOk.Text = "";

                    LabelError.Text = "Error, Farmacos inexistentes";

                    ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "Error, Farmacos aplicados innexistentes con criterios de busqueda." + "');", true);

                }

            }

        }
    }
}