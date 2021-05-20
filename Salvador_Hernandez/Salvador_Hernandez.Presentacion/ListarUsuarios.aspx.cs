using System;

using System.Collections.Generic;

using System.Data;

using System.Linq;

using System.Web;

using System.Web.UI;

using System.Web.UI.WebControls;

using Salvador_Hernandez.AccesoDatos;



namespace Salvador_Hernandez.Presentacion

{

    public partial class ListarUsuarios : System.Web.UI.Page

    {

        protected void Page_Load(object sender, EventArgs e)

        {


            Listar();
            Usuario user = (Usuario)Session["Usuario"];

            if (!user.TipoUsuario.Equals("1"))

            {

                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('No tienes acceso a esta pagina, inicie session con las credenciales correspondientes');window.location ='login.aspx'", true);

            }

           



        }



        public void Listar()

        {

            DataTable dt = UsuarioDAO.ObtenerDatos();

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





                if (UsuarioDAO.Eliminar(Rut) == true)

                {

                    LabelOk.Text = "Usuario eliminado";

                    Listar();

                    LabelError.Text = "";

                    ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "Usuario Eliminado" + "');", true);

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

            /*

            string Rut = txtRUT.Text;





            if (!Rut.Equals(""))

            {



                DataTable dt = UsuarioDAO.Buscar(Rut);

                try

                {

                    if (dt.Rows[0]["RUT_USUARIO"].ToString().Equals(Rut))

                    {



                        GridView1.DataSource = dt;

                        GridView1.DataBind();

                        LabelOk.Text = "Usuario encontrado";

                        LabelError.Text = "";



                    }

                }

                catch (IndexOutOfRangeException)

                {

                    LabelOk.Text = "";

                    LabelError.Text = "Error, usuario no existe con ese RUT";

                    ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "Error, rut no existe" + "');", true);

                }

            }*/

        }





    }

}