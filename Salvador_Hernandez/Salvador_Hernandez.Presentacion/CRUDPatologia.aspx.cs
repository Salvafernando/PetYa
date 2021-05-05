using Salvador_Hernandez.AccesoDatos;

using Salvador_Hernandez.Entity;

using System;

using System.Collections.Generic;

using System.Linq;

using System.Web;

using System.Web.UI;

using System.Web.UI.WebControls;



namespace Salvador_Hernandez.Presentacion

{

    public partial class CRUDPatologia : System.Web.UI.Page

    {

        protected void Page_Load(object sender, EventArgs e)

        {



        }



        protected void Button2_Click(object sender, EventArgs e)

        {

            string Nombre = TextBoxNombre.Text;

            string descripcion = TextBoxDescripcion.Text;



            if (!Nombre.Equals("") && !descripcion.Equals(""))

            {

                Patologia pat = new Patologia(0, Nombre, descripcion);

                if (PatologiaDAO.Agregar(pat) == true)

                {

                    ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "Bien, datos agregados correctamente" + "');", true);

                    LabelError.Text = "";

                    LabelOk.Text = "Bien, Insumo creado";

                }

                else

                {

                    LabelOk.Text = "";

                    LabelError.Text = "Error, Insumo ya existe";

                }

            }

            else

            {

                LabelOk.Text = "";

                LabelError.Text = "Error, hay campos vacios";

            }

        }



        protected void Button4_Click(object sender, EventArgs e)

        {

            String Idtxt = TextBoxId.Text;

            if (!Idtxt.Equals(""))

            {

                int Id = Int32.Parse(Idtxt);



                Patologia pat = PatologiaDAO.Buscar(Id);



                if (pat != null)

                {

                    TextBoxNombre.Text = pat.Nombre;

                    TextBoxDescripcion.Text = pat.Descripcion;

                    LabelOk.Text = "Busqueda exitosa";

                    LabelError.Text = "";

                }

                else

                {

                    ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "Error, id no existe" + "');", true);

                    LabelOk.Text = "";

                    LabelError.Text = "Error, patología no existe con ese ID";

                }

            }

        }



        protected void ButtonEliminar_Click(object sender, EventArgs e)

        {

            string Id = TextBoxId.Text;

            if (PatologiaDAO.Eliminar(int.Parse(Id)) == true)

            {

                string mensaje = "Bien, datos eliminados";

                LabelError.Text = "";

                LabelOk.Text = "Bien, patología eliminada.";

                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + mensaje + "');", true);

            }

            else

            {

                LabelOk.Text = "";

                LabelError.Text = "Error, patología no existe con ese ID";

            }

        }



        protected void Button6_Click(object sender, EventArgs e)

        {

            string Id = TextBoxId.Text;

            string Nombre = TextBoxNombre.Text;

            string descripcion = TextBoxDescripcion.Text;

            if (!Id.Equals(""))

            {

                Patologia pat = new Patologia(Int32.Parse(Id), Nombre, descripcion);



                if (PatologiaDAO.Modificar(pat) == true)

                {

                    ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "Bien, datos modificados" + "');", true);

                    LabelOk.Text = "Bien, patología modificada exitosamente.";

                    LabelError.Text = "";

                }

                else

                {

                    LabelOk.Text = "";

                    ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "Error, datos no modificados" + "');", true);

                    LabelError.Text = "Error, patología no existe con ese ID";

                }



            }

        }



        protected void Button7_Click(object sender, EventArgs e)

        {

            Response.Redirect("ListaPatologia.aspx");

        }

    }

}