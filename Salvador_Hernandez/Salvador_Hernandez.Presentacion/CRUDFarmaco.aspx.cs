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
    public partial class CRUDFarmaco : System.Web.UI.Page

    {

        protected void Page_Load(object sender, EventArgs e)

        {

            Usuario user = (Usuario)Session["Usuario"];

            if (!user.TipoUsuario.Equals("1"))

            {

                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('No tienes acceso a esta pagina, inicie session con las credenciales correspondientes');window.location ='login.aspx'", true);

            }

        }



        protected void Button1_Click(object sender, EventArgs e)

        {



            int Id = Convert.ToInt32(TextBoxId.Text);

            string Nombre = TextBoxNombre.Text;

            string Descripcion = TextBoxDescripcion.Text;

            int Valor = Convert.ToInt32(TextBoxPrecio.Text);

            int Cantidad = Convert.ToInt32(TextBoxCantidad.Text);





            if (!Id.Equals("") && !Nombre.Equals("") && !Descripcion.Equals("")

                && !Valor.Equals("") && !Cantidad.Equals(""))

            {

                Farmaco farmaco = new Farmaco(Id, Nombre,

                    Descripcion, Valor, Cantidad);

                if (FarmacoDAO.Agregar(farmaco) == true)

                {

                    ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "Bien, datos agregados correctamente" + "');", true);

                    LabelOk.Text = "Datos agregados correctamente";

                    LabelError.Text = "";

                }

                else

                {

                    LabelOk.Text = "";

                    LabelError.Text = "Error, Farmaco ya existe";

                }

            }

            else

            {

                LabelOk.Text = "";

                LabelError.Text = "Error, hay campos vacios";

            }

        }



        protected void ButtonBuscar_Click(object sender, EventArgs e)

        {



            int Id = Convert.ToInt32(TextBoxId.Text);





            if (!Id.Equals(""))

            {

                Farmaco farmaco = FarmacoDAO.Buscar(Id);



                if (farmaco != null)

                {

                    TextBoxId.Text = farmaco.Id.ToString();

                    TextBoxNombre.Text = farmaco.Nombre;

                    TextBoxDescripcion.Text = farmaco.Descripcion;

                    TextBoxPrecio.Text = farmaco.Valor.ToString();

                    TextBoxCantidad.Text = farmaco.Cantidad.ToString();

                    LabelOk.Text = "Busqueda exitosa";

                }

                else

                {

                    LabelOk.Text = "";

                    LabelError.Text = "Error, farmaco no existe con ese Id";

                    ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "Error, Id no existe" + "');", true);

                }

            }

        }



        protected void ButtonEliminar_Click(object sender, EventArgs e)

        {



            int Id = Convert.ToInt32(TextBoxId.Text);

            if (FarmacoDAO.Eliminar(Id) == true)

            {

                string mensaje = "Bien, datos eliminados";

                LabelError.Text = "";

                LabelOk.Text = "Bien, farmaco eliminado.";

                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + mensaje + "');", true);

            }

            else

            {

                LabelOk.Text = "";

                LabelError.Text = "Error, farmaco no existe con ese Id";

            }

        }



        protected void ButtonModificar_Click(object sender, EventArgs e)

        {

            int Id = Convert.ToInt32(TextBoxId.Text);

            string Nombre = TextBoxNombre.Text;

            string Descripcion = TextBoxDescripcion.Text;

            int Valor = Convert.ToInt32(TextBoxPrecio.Text);

            int Cantidad = Convert.ToInt32(TextBoxCantidad.Text);



            if (!Id.Equals("") && !Nombre.Equals("") && !Descripcion.Equals("")

                && !Valor.Equals("") && !Cantidad.Equals(""))

            {



                Farmaco farmaco = new Farmaco(Id, Nombre,

                    Descripcion, Valor, Cantidad);



                if (FarmacoDAO.Modificar(farmaco) == true)

                {

                    ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "Bien, datos modificados" + "');", true);

                    LabelOk.Text = "Bien, farmaco modificado exitosamente.";

                }

                else

                {

                    LabelOk.Text = "";

                    ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "Error, datos no modificados" + "');", true);

                    LabelError.Text = "Error, farmaco no existe con ese Id";

                }

            }

        }



        protected void Button5_Click(object sender, EventArgs e)

        {

            Response.Redirect("ListaFarmaco.aspx");

        }

    }
}