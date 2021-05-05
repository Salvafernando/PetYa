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
    public partial class CRUDExamen : System.Web.UI.Page
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





                if (!Id.Equals("") && !Nombre.Equals("") && !Descripcion.Equals("")

                    && !Valor.Equals(""))

                {

                    Examen examen = new Examen(Id, Nombre,

                        Descripcion, Valor);

                    if (ExamenDAO.Agregar(examen) == true)

                    {

                        ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "Bien, datos agregados correctamente" + "');", true);

                        LabelOk.Text = "Datos agregados correctamente";

                        LabelError.Text = "";

                    }

                    else

                    {

                        LabelOk.Text = "";

                        LabelError.Text = "Error, examen ya existe";

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

                    Examen examen = ExamenDAO.Buscar(Id);



                    if (examen != null)

                    {

                        TextBoxId.Text = examen.Id.ToString();

                        TextBoxNombre.Text = examen.Nombre;

                        TextBoxDescripcion.Text = examen.Descripcion;

                        TextBoxPrecio.Text = examen.Valor.ToString();

                        LabelOk.Text = "Busqueda exitosa";

                    }

                    else

                    {

                        LabelOk.Text = "";

                        LabelError.Text = "Error, examen no existe con ese Id";

                        ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "Error, Id no existe" + "');", true);

                    }

                }

            }



            protected void ButtonEliminar_Click(object sender, EventArgs e)

            {



                int Id = Convert.ToInt32(TextBoxId.Text);

                if (ExamenDAO.Eliminar(Id) == true)

                {

                    string mensaje = "Bien, datos eliminados";

                    LabelError.Text = "";

                    LabelOk.Text = "Bien, farmaco eliminado.";

                    ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + mensaje + "');", true);

                }

                else

                {

                    LabelOk.Text = "";

                    LabelError.Text = "Error, examen no existe con ese Id";

                }

            }



            protected void ButtonModificar_Click(object sender, EventArgs e)

            {

                int Id = Convert.ToInt32(TextBoxId.Text);

                string Nombre = TextBoxNombre.Text;

                string Descripcion = TextBoxDescripcion.Text;

                int Valor = Convert.ToInt32(TextBoxPrecio.Text);



                if (!Id.Equals("") && !Nombre.Equals("") && !Descripcion.Equals("")

                    && !Valor.Equals(""))

                {



                    Examen examen = new Examen(Id, Nombre,

                        Descripcion, Valor);



                    if (ExamenDAO.Modificar(examen) == true)

                    {

                        ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "Bien, datos modificados" + "');", true);

                        LabelOk.Text = "Bien, examen modificado exitosamente.";

                    }

                    else

                    {

                        LabelOk.Text = "";

                        ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "Error, datos no modificados" + "');", true);

                        LabelError.Text = "Error, examen no existe con ese Id";

                    }

                }

            }



            protected void Button5_Click(object sender, EventArgs e)

            {

                Response.Redirect("ListaExamen.aspx");

            }



        }
    }
