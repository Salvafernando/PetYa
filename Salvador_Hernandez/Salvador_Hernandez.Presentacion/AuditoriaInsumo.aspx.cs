using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Salvador_Hernandez.Presentacion
{
    public partial class AuditoriaInsumo : System.Web.UI.Page
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
            DataTable dt = Salvador_Hernandez.AccesoDatos.Auditoria.ObtenerDatosInsumo();
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)

        {
        }

        protected void BtnBuscar_Click(object sender, EventArgs e)

        {

            string accion = txtAccion.Text;
            if (!accion.Equals(""))

            {
                try

                {

                    DataTable dt = Salvador_Hernandez.AccesoDatos.Auditoria.BuscarInsumo(accion);



                    GridView1.DataSource = dt;

                    GridView1.DataBind();

                    if (dt.Rows[0]["ACCION"].ToString().Equals(accion))

                    {

                    }
                    LabelOk.Text = "Auditorias encontradas por acción";

                    LabelError.Text = "";

                }

                catch (IndexOutOfRangeException)

                {

                    LabelOk.Text = "";

                    LabelError.Text = "Error, Auditorias inexistentes";

                    ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "Error, Auditorias innexistentes con criterios de busqueda." + "');", true);

                }

            }

        }
    }
}