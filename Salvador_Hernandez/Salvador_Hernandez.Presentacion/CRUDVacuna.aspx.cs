using Salvador_Hernandez.AccesoDatos;

using Salvador_Hernandez.Entity;

using System;

using System.Collections.Generic;

using System.Data;

using System.Data.SqlClient;

using System.Linq;

using System.Web;

using System.Web.UI;

using System.Web.UI.WebControls;



namespace Salvador_Hernandez

{

    public partial class CRUDVacuna : System.Web.UI.Page

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

                Vacuna vacuna = new Vacuna(Id, Nombre,

                    Descripcion, Valor, Cantidad);

                if (VacunaDAO.Agregar(vacuna) == true)

                {

                    ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "Bien, datos agregados correctamente" + "');", true);

                    LabelOk.Text = "Datos agregados correctamente";

                    LabelError.Text = "";

                }

                else

                {

                    LabelOk.Text = "";

                    LabelError.Text = "Error, Vacuna ya existe";

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

                Vacuna vacuna = VacunaDAO.Buscar(Id);



                if (vacuna != null)

                {

                    TextBoxId.Text = vacuna.Id.ToString();

                    TextBoxNombre.Text = vacuna.Nombre;

                    TextBoxDescripcion.Text = vacuna.Descripcion;

                    TextBoxPrecio.Text = vacuna.Valor.ToString();

                    TextBoxCantidad.Text = vacuna.Cantidad.ToString();

                    LabelOk.Text = "Busqueda exitosa";

                }

                else

                {

                    LabelOk.Text = "";

                    LabelError.Text = "Error, vacuna no existe con ese Id";

                    ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "Error, Id no existe" + "');", true);

                }

            }

        }



        protected void ButtonEliminar_Click(object sender, EventArgs e)

        {



            int Id = Convert.ToInt32(TextBoxId.Text);

            if (VacunaDAO.Eliminar(Id) == true)

            {

                string mensaje = "Bien, datos eliminados";

                LabelError.Text = "";

                LabelOk.Text = "Bien, vacuna eliminada.";

                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + mensaje + "');", true);

            }

            else

            {

                LabelOk.Text = "";

                LabelError.Text = "Error, vacuna no existe con ese Id";

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



                Vacuna vacuna = new Vacuna(Id, Nombre,

                    Descripcion, Valor, Cantidad);



                if (VacunaDAO.Modificar(vacuna) == true)

                {

                    ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "Bien, datos modificados" + "');", true);

                    LabelOk.Text = "Bien, vacuna modificada exitosamente.";

                }

                else

                {

                    LabelOk.Text = "";

                    ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "Error, datos no modificados" + "');", true);

                    LabelError.Text = "Error, vacuna no existe con ese Id";

                }

            }

        }



        
    }

}