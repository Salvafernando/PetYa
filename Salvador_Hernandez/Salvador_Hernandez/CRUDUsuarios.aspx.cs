using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Salvador_Hernandez
{
    public partial class CRUDUsuarios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (UsuarioDAO.getSW() == 0)
            {
                UsuarioDAO.llenar();
            }
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                string Rut = TextBoxRut.Text;
                string Nombre = TextBoxNombre.Text;
                string Username = TextBoxUsername.Text;
                string Password = TextBoxPassword.Text;
                string Repassword = TextBoxRepassword.Text;

                if (!Rut.Equals("") && !Nombre.Equals("") && !Username.Equals("") && !Password.Equals("")&& TextBoxPassword.Text==TextBoxRepassword.Text)
                {
                    Usuario user = new Usuario(Rut, Nombre, Username, Password);
                    if (UsuarioDAO.Agregar(user) == true)
                    {
                        LabelError.Text = "";
                        LabelOk.Text = "Bien, usuario creado";
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

        protected void ButtonBuscar_Click(object sender, EventArgs e)
        {
            string Rut = TextBoxRut.Text;
            if (!Rut.Equals("") )
            {
                Usuario user = UsuarioDAO.Buscar(Rut);

                if (user != null)
                {
                    TextBoxRut.Text = user.Rut;
                    TextBoxNombre.Text = user.Nombre;
                    TextBoxUsername.Text = user.Username;
                    TextBoxPassword.Text = user.Password;
                    LabelOk.Text = "Busqueda exitosa";
                }
                else
                {
                    LabelOk.Text = "";
                    LabelError.Text = "Error, usuario no existe con ese RUT";
                }
            }
        }

        protected void ButtonEliminar_Click(object sender, EventArgs e)
        {
            string Rut = TextBoxRut.Text;
            if (UsuarioDAO.Eliminar(Rut) == true)
            {
                LabelError.Text = "";
                LabelOk.Text = "Bien, usuario eliminado.";
            }
            else
            {
                LabelOk.Text = "";
                LabelError.Text = "Error, usuario no existe con ese RUT";
            }
        }

        protected void ButtonModificar_Click(object sender, EventArgs e)
        {
            string Rut = TextBoxRut.Text;
            if (!Rut.Equals(""))
            {
                Usuario user = UsuarioDAO.Buscar(Rut);

                if (user != null)
                {
                    user.Rut = TextBoxRut.Text ;
                    user.Nombre = TextBoxNombre.Text;
                    user.Username = TextBoxUsername.Text;
                    user.Password = TextBoxPassword.Text;
                    LabelOk.Text = "Bien, usuario modificado exitosamente.";
                }
                else
                {
                    LabelOk.Text = "";
                    LabelError.Text = "Error, usuario no existe con ese RUT";
                }
            }
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Response.Redirect("ListaUsuariosForm.aspx");
        }
    }
}