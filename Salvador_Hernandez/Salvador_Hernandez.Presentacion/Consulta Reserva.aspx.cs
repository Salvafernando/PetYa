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
    public partial class Consulta_Reserva : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Usuario user = (Usuario)Session["Usuario"];

            txtID.Text = user.Rut;
        }

        protected void GridView1_rowDelete(object sender, GridViewDeleteEventArgs e)

        {

 

            string ID = GridView1.Rows[e.RowIndex].Cells[1].Text;

            if (!ID.Equals(""))
            {
                VeterinarioDAO.ActualizaVetTH(ID);
                if (VeterinarioDAO.EliminarReserva(ID) !=null)

                {

                    LabelOk.Text = "Reserva Eliminada";



                    LabelError.Text = "";

                    ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "Reserva eliminada" + "');", true);

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



                DataTable dt =VeterinarioDAO.BuscarReserva(ID);

                try

                {

                    if (VeterinarioDAO.BuscarReserva(ID)!=null)

                    {



                        GridView1.DataSource = dt;

                        GridView1.DataBind();

                        LabelOk.Text = "Reserva Encontra";

                        LabelError.Text = "";



                    }

                }

                catch (IndexOutOfRangeException)

                {

                    LabelOk.Text = "";

                    LabelError.Text = "No tiene reservas confirmadas";

                    ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "No tiene reservas confirmadas" + "');", true);

                }

            }
        }
    }
}