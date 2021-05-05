using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Salvador_Hernandez.AccesoDatos;

namespace Salvador_Hernandez
{
    public partial class ListaPacienteForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void listar()
        {



        }
        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void GridView1_rowDelete(object sender, GridViewDeleteEventArgs e)
        {
            //String Rut = GridView1.Rows[e.RowIndex].DataItem.ToString();
            string ID = GridView1.Rows[e.RowIndex].Cells[1].Text;
            if (!ID.Equals(""))
            {


                if (MascotaDAO.Eliminar(ID) == true)
                {
                    LabelOk.Text = "Mascota Eliminada";

                    LabelError.Text = "";
                    ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "Mascota eliminada" + "');", true);
                }
                else
                {
                    LabelOk.Text = "";
                    LabelError.Text = "Error al Eliminar";
                    ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "Error al eliminar" + "');", true);
                }

            }
        }

        protected void BtnBuscar_Click(object sender, EventArgs e)
        {

            string ID = txtID.Text;


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