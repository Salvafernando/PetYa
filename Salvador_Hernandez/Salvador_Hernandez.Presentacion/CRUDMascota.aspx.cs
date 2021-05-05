using Salvador_Hernandez.AccesoDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Salvador_Hernandez
{
    public partial class CRUDMascota : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            Response.Redirect("ListaPacienteForm.aspx");
        }

        protected void ButtonVerCalendario_Click(object sender, EventArgs e)
        {
            Calendar1.Visible = true;
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            TextBoxFechaNac.Text = Calendar1.SelectedDate.ToString("dd-MM-yyyy");
            Calendar1.Visible = false;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {

            
                string NombreMascota = txtNombre.Text;
                string Raza = txtRaza.Text;
            string Especie = txtEspecie.Text;
                string FechaNac = TextBoxFechaNac.Text;
                string Genero = DropDownListGenero.SelectedValue.ToString();
                string Foto = TextBoxFoto.Text;
                string RutDueno = TextBoxRutDueno.Text;
               

                if (!NombreMascota.Equals("") && !Raza.Equals("") && !FechaNac.Equals("") &&
                    !Genero.Equals("") && !Foto.Equals("") && !RutDueno.Equals("") )
                {
                    DataTable dt = MascotaDAO.Agregar(NombreMascota, Raza, DateTime.Parse(FechaNac), Genero, Foto, RutDueno, Especie);
                    if (dt!=null)
                    {
                        ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "Bien, datos agregados correctamente" + "');", true);
                        LabelError.Text = "";
                        LabelOk.Text = "Bien, paciente creado";
                    }
                    else
                    {
                        LabelOk.Text = "";
                        LabelError.Text = "Error, paciente ya existe";
                    }
                }
                else
                {
                    LabelOk.Text = "";
                    LabelError.Text = "Error, hay campos vacios";
                }
            
           
        }


        protected void ButtonEliminar_Click(object sender, EventArgs e)
        {
            string NombreMascota = txtNombre.Text;
            string RutDueno = TextBoxRutDueno.Text;


            if (!NombreMascota.Equals("") && !RutDueno.Equals(""))
            {
                DataTable dt = MascotaDAO.EliminarMascota(NombreMascota, RutDueno);
                if (dt != null)
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "Bien, datos eliminados correctamente" + "');", true);
                    LabelError.Text = "";
                    LabelOk.Text = "Bien, mascota eliminada creado";
                    txtNombre.Text = "";
                   txtRaza.Text = "";
                    txtEspecie.Text = "";
                    TextBoxFechaNac.Text = "";
                    DropDownListGenero.SelectedValue.ToString();
                    TextBoxFoto.Text = "";
                   TextBoxRutDueno.Text = "";

                }
                else
                {
                    LabelOk.Text = "";
                    LabelError.Text = "Error, no existe mascota asociada al rut del dueño";
                }
            }
            else
            {
                LabelOk.Text = "";
                LabelError.Text = "Error, hay campos vacios. Debe ingresar nombre y rut del dueño para poder eliminar";
            }

        }

      
      

        protected void Button6_Click(object sender, EventArgs e)
        {
            string NombreMascota = txtNombre.Text;
            string Raza = txtRaza.Text;
            string Especie = txtEspecie.Text;
            string FechaNac = TextBoxFechaNac.Text;
            string Genero = DropDownListGenero.SelectedValue.ToString();
            string Foto = TextBoxFoto.Text;
            string RutDueno = TextBoxRutDueno.Text;


            if (!NombreMascota.Equals("") && !Raza.Equals("") && !FechaNac.Equals("") &&
                !Genero.Equals("") && !Foto.Equals("") && !RutDueno.Equals(""))
            {

                DataTable dt = MascotaDAO.Agregar(NombreMascota, Raza, DateTime.Parse(FechaNac), Genero, Foto, RutDueno, Especie);
                if (dt!=null)
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "Bien, datos modificados" + "');", true);
                    LabelOk.Text = "Bien, mascota modificado exitosamente.";
                    LabelError.Text = "";
                }
                else
                {
                    LabelOk.Text = "";
                    ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "Error, datos no modificados" + "');", true);
                    LabelError.Text = "Error, mascota no existe asociada a ese rut";
                }

            }
        }
        
        }
    }

    
        
    
