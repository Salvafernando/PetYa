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
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

      

        protected void btnBusqueda_Click(object sender, EventArgs e)
        {
            string Rut = txtRutDueno.Text;


            if (!Rut.Equals(""))
            {

                string user = UsuarioDAO.BuscarUsuario(Rut);
                DataTable dt = UsuarioDAO.BuscarMascota(Rut);
                Console.WriteLine(user);
                if (user != null)
                {
                    txtRutDueno.Text = Rut;
                    LabelOk.Text = "Busqueda exitosa";
                    LabelError.Text = "";



                    txtRutDueno.Text = Rut;

                    ddlMascota.DataSource = dt;
                    ddlMascota.DataTextField = "nombre";
                    ddlMascota.DataValueField = "id_dueno";
                    ddlMascota.DataBind();

                    ddlMascota.Items.Insert(0, new ListItem("--Seleccionar--", "0"));


                    LabelError.Text = "";


                }
                else
                {
                    LabelOk.Text = "";
                    LabelError.Text = "Error, usuario no existe con ese RUT";
                    ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "Error, rut no existe" + "');", true);
                }
            }
        }

        protected void ddlMascota_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Rut = txtRutDueno.Text;

            if (ddlMascota.SelectedItem != null)
            {

                txtNombreMascota.Text = ddlMascota.SelectedItem.Text.ToString();

                string Nombre = txtNombreMascota.Text;

                DataTable dt = MascotaDAO.BuscarFicha(Nombre, Rut);

                if (Nombre.ToString() != null)
                {
                    txtNombreMascota.Text = dt.Rows[0][0].ToString();
                    txtRaza.Text = dt.Rows[0][1].ToString();
                    txtEspecie.Text = dt.Rows[0][2].ToString();
                    txtSexo.Text = dt.Rows[0][3].ToString();
                    txtFechaNacimiento.Text = dt.Rows[0][4].ToString();
                    txtPeso.Text = dt.Rows[0][5].ToString();
                    txtTemperatura.Text = dt.Rows[0][6].ToString();
                    txtFrecCardiaca.Text = dt.Rows[0][7].ToString();
                    txtFrecRespiratoria.Text = dt.Rows[0][8].ToString();
                    txtAnamnesis.InnerText = dt.Rows[0][9].ToString();
                    txtSVitales.Text = dt.Rows[0][10].ToString();
                    txtPDiagnostico.InnerText = dt.Rows[0][11].ToString();
                    txtDiagnostico.InnerText = dt.Rows[0][12].ToString();
                    txtPronostico.InnerText = dt.Rows[0][13].ToString();
                    txtTratamiento.InnerText = dt.Rows[0][14].ToString();
                    txtObservaciones.InnerText = dt.Rows[0][15].ToString();
                }



              

            }
            else
            {

            }
        
    }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            string Rut = txtRutDueno.Text;
            string nombre = txtNombreMascota.Text;

            int peso =int.Parse(txtPeso.Text);
            int temperatura = int.Parse(txtTemperatura.Text);
            int fcardiaca = int.Parse(txtFrecCardiaca.Text);
            int frespiratoria = int.Parse(txtFrecRespiratoria.Text);
            string anamnesis =txtAnamnesis.InnerText ;
            string svitale = txtSVitales.Text ;
            string pdiagnostico =txtPDiagnostico.InnerText;
            string diagnostivo = txtDiagnostico.InnerText ;
            string pronostico = txtPronostico.InnerText ;
            string tratamiento = txtTratamiento.InnerText ;
            string observaciones = txtObservaciones.InnerText ;

            DataTable dt = MascotaDAO.ActualizarFicha(nombre, Rut, peso, temperatura, fcardiaca, frespiratoria, anamnesis, svitale, pdiagnostico, diagnostivo, pronostico, tratamiento, observaciones);
            if (dt!=null)
            {
                LabelOk.Text = "Ficha actualizada"+dt;

            }
        }

        protected void btnVolverFicha_Click(object sender, EventArgs e)
        {
            Response.Redirect("FichaMascota.aspx");
        }
    }
}