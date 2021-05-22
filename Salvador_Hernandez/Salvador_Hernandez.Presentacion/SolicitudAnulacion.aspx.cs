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
    public partial class SolicitudAnulacion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            Usuario user = (Usuario)Session["Usuario"];

            txtRut.Text = user.Rut;
        }

        protected void BtnBuscar_Click(object sender, EventArgs e)
        {
            string ID = txtRut.Text;


            if (!ID.Equals(""))
            {

                DataTable dt = MascotaDAO.Buscar(ID);
                try
                {
                    if (dt.Rows[0]["ID_DUENO"].ToString().Equals(ID))
                    {

                        GridView1.DataSource = dt;
                        GridView1.DataBind();
                        LabelOk.Text = "Mascota encontrada";
                        LabelError.Text = "";

                    }
                }
                catch (IndexOutOfRangeException)
                {
                    LabelOk.Text = "";
                    LabelError.Text = "Error, Mascota no existe con esa ID";
                    ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "Error, Mascota no existe" + "');", true);
                }
            }
        }
    }
}