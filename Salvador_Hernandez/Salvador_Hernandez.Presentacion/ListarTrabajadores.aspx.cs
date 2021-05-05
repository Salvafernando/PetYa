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

    public partial class ListarTrabajadores : System.Web.UI.Page

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

            DataTable dt = Salvador_Hernandez.AccesoDatos.VeterinarioDAO.ObtenerDatos();

            GridView1.DataSource = dt;

            GridView1.DataBind();





        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)

        {



        }



        protected void GridView1_rowDelete(object sender, GridViewDeleteEventArgs e)

        {

            //String Rut = GridView1.Rows[e.RowIndex].DataItem.ToString();

            string Rut = GridView1.Rows[e.RowIndex].Cells[1].Text;

            if (!Rut.Equals(""))

            {





                if (Salvador_Hernandez.AccesoDatos.VeterinarioDAO.Eliminar(Rut) == true)

                {

                    LabelOk.Text = "Trabajador eliminado";



                    LabelError.Text = "";

                    ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "Trabajador Eliminado" + "');", true);

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



            string Rut = txtRUT.Text;





            if (!Rut.Equals(""))

            {



                DataTable dt = Salvador_Hernandez.AccesoDatos.VeterinarioDAO.Buscar(Rut);

                try

                {

                    if (dt.Rows[0]["RUT_VET"].ToString().Equals(Rut))

                    {



                        GridView1.DataSource = dt;

                        GridView1.DataBind();

                        LabelOk.Text = "Trabajador encontrado";

                        LabelError.Text = "";



                    }

                }

                catch (IndexOutOfRangeException)

                {

                    LabelOk.Text = "";

                    LabelError.Text = "Error, Trabajador no existe con ese RUT";

                    ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "Error, rut no existe" + "');", true);

                }

            }

        }

    }

}