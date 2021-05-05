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
    public partial class BusquedaInfoVet : System.Web.UI.Page
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

           

            protected void BtnBuscar_Click(object sender, EventArgs e)
            {

                string ID = txtID.Text;


                if (!ID.Equals(""))
                {

                    DataTable dt = MascotaDAO.BuscarInfoVet(ID);
                    try
                    {
                        if (dt!=null)
                        {

                            GridView1.DataSource = dt;
                            GridView1.DataBind();
                            LabelOk.Text = "Datos encontrados";
                            LabelError.Text = "";

                        }
                    }
                    catch (IndexOutOfRangeException)
                    {
                        LabelOk.Text = "";
                        LabelError.Text = "Error, no hay datos  no disponibles";
                        ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "Error, no hay datos disponibles" + "');", true);
                    }
                }
            }
        }
    }
   
