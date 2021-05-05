using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Salvador_Hernandez
{
    public partial class CRUDPacientes : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (PacienteDAO.getSW() == 0)
            {
                PacienteDAO.llenar();
            }
            // GridView1.DataSource = PacienteDAO.ObtenerDatos();
            // GridView1.DataBind();
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
            try
            {
                string Id = TextBoxId.Text;
                string NombreMascota = TextBoxNomMasc.Text;
                string Raza = TextBoxRaza.Text;
                string FechaNac = TextBoxFechaNac.Text;
                string Genero = DropDownListGenero.SelectedValue.ToString();
                string Foto = TextBoxFoto.Text;
                string RutDueno = TextBoxRutDueno.Text;
                string NombreDueno = TextBoxNomDueno.Text;

                if (!Id.Equals("") && !NombreMascota.Equals("") && !Raza.Equals("") && !FechaNac.Equals("") &&
                    !Genero.Equals("") && !Foto.Equals("") && !RutDueno.Equals("") && !NombreDueno.Equals(""))
                {
                    Paciente paciente = new Paciente(int.Parse(Id), NombreMascota, Raza, DateTime.Parse(FechaNac), Genero, Foto, RutDueno, NombreDueno);
                    if (PacienteDAO.Agregar(paciente) == true)
                    {
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
            catch (Exception ex)
            {
                LabelOk.Text = "";
                LabelError.Text = "Error, hay campos vacios";
            }
        }


        protected void ButtonEliminar_Click(object sender, EventArgs e)
        {
            string Id = TextBoxId.Text;
            if (PacienteDAO.Eliminar(int.Parse(Id)) == true)
            {
                LabelError.Text = "";
                LabelOk.Text = "Bien, paciente eliminado.";
            }
            else
            {
                LabelOk.Text = "";
                LabelError.Text = "Error, paciente no existe con ese ID";
            }
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            string id = TextBoxId.Text;
            if (!id.Equals(""))
            {
                Paciente paciente = PacienteDAO.Buscar(int.Parse(id));

                if (paciente != null)
                {
                    TextBoxNomMasc.Text = paciente.NombreMascota;
                    TextBoxRaza.Text = paciente.Raza;
                    TextBoxFechaNac.Text = paciente.FechaNac.ToString();
                    TextBoxNomDueno.Text = paciente.NombreDueno;
                    TextBoxRutDueno.Text = paciente.RutDueno;
                    DropDownListGenero.SelectedValue = paciente.Genero;
                    TextBoxFoto.Text = paciente.Foto;
                }
                else
                {
                    LabelOk.Text = "";
                    LabelError.Text = "Error, paciente no existe con ese ID";
                }
            }
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            string id = TextBoxId.Text;
            if (!id.Equals(""))
            {
                Paciente paciente = PacienteDAO.Buscar(int.Parse(id));

                if (paciente != null)
                {
                    paciente.NombreMascota = TextBoxNomMasc.Text;

                    paciente.Raza = TextBoxRaza.Text;
                    paciente.FechaNac = DateTime.Parse(TextBoxFechaNac.Text);
                    paciente.NombreDueno = TextBoxNomDueno.Text;
                    paciente.RutDueno = TextBoxRutDueno.Text;
                    paciente.Genero = DropDownListGenero.SelectedValue ;
                    paciente.Foto = TextBoxFoto.Text ;
                    LabelOk.Text = "Bien, paciente modificado exitosamente.";
                }
                else
                {
                    LabelOk.Text = "";
                    LabelError.Text = "Error, paciente no existe con ese ID";
                }

            }
        }
    }
}
    
        
    
