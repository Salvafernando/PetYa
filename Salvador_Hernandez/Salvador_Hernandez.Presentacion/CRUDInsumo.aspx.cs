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
    public partial class CRUDInsumo : System.Web.UI.Page

    {

        protected void Page_Load(object sender, EventArgs e)

        {



        }



        protected void Button2_Click(object sender, EventArgs e)

        {



            string Id = TextBoxId.Text;

            string Nombre = TextBoxNombre.Text;

            string descripcion = TextBoxDescripcion.Text;

            int precio = Int32.Parse(TextBoxPrecio.Text);

            int cantidad = Int32.Parse(TextBoxPrecio.Text);



            if (!Id.Equals("") && !Nombre.Equals("") && !descripcion.Equals("") && precio > 0 && cantidad > 0)

            {

                Insumo insumo = new Insumo(Int32.Parse(Id), Nombre, descripcion, precio, cantidad);

                if (InsumoDAO.Agregar(insumo) == true)

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

            int Id = int.Parse(TextBoxId.Text);

            if (!Id.Equals(""))

            {



                Insumo ins = InsumoDAO.Buscar(Id);



                if (ins != null)

                {

                    TextBoxNombre.Text = ins.Nombre;

                    TextBoxDescripcion.Text = ins.Descripcion;

                    TextBoxPrecio.Text = ins.Precio.ToString();

                    TextBoxCantidad.Text = ins.Cantidad.ToString();

                    LabelOk.Text = "Busqueda exitosa";

                    LabelError.Text = "";

                }

                else

                {

                    ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "Error, id no existe" + "');", true);

                    LabelOk.Text = "";

                    LabelError.Text = "Error, insumo no existe con ese ID";

                }

            }





        }



        protected void ButtonEliminar_Click(object sender, EventArgs e)

        {

            string Id = TextBoxId.Text;

            if (InsumoDAO.Eliminar(int.Parse(Id)) == true)

            {

                string mensaje = "Bien, datos eliminados";

                LabelError.Text = "";

                LabelOk.Text = "Bien, insumo eliminado.";

                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + mensaje + "');", true);

            }

            else

            {

                LabelOk.Text = "";

                LabelError.Text = "Error, insumo no existe con ese ID";

            }

        }



        protected void Button6_Click(object sender, EventArgs e)

        {

            string Id = TextBoxId.Text;

            string Nombre = TextBoxNombre.Text;

            string descripcion = TextBoxDescripcion.Text;

            int precio = Int32.Parse(TextBoxPrecio.Text);

            int cantidad = Int32.Parse(TextBoxPrecio.Text);

            if (!Id.Equals(""))

            {

                Insumo ins = new Insumo(Int32.Parse(Id), Nombre, descripcion, precio, cantidad);



                if (InsumoDAO.Modificar(ins) == true)

                {

                    ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "Bien, datos modificados" + "');", true);

                    LabelOk.Text = "Bien, paciente modificado exitosamente.";

                    LabelError.Text = "";

                }

                else

                {

                    LabelOk.Text = "";

                    ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "Error, datos no modificados" + "');", true);

                    LabelError.Text = "Error, paciente no existe con ese ID";

                }



            }

        }



        protected void Button7_Click(object sender, EventArgs e)

        {

            Response.Redirect("ListaInsumo.aspx");

        }

    }
}