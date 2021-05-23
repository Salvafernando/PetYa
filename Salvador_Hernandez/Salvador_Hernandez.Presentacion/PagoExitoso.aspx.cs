using Salvador_Hernandez.AccesoDatos;
using Salvador_Hernandez.Entity;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Salvador_Hernandez.Presentacion
{
    public partial class PagoExitoso : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            Usuario user = (Usuario)Session["Usuario"];


            txtRut.Text = user.Rut;

            Reserva reserva = (Reserva)Session["Reserva"];
            txtFecha.Text = reserva.Fecha1;
            txtHorario.Text = reserva.Hora1;
            txtVeterinario.Text = reserva.Veterinario1;
            DataTable dt = VeterinarioDAO.BuscarIdReserva(reserva.Veterinario1, reserva.Fecha1, reserva.Hora1);
            txtIdReserva.Text = dt.Rows[0][0].ToString();


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (txtIdReserva.Text != null && txtHorario.Text != null && txtFecha.Text != null && txtRut.Text != null)
            {
                VeterinarioDAO.ActualizaEstadoVetH(txtIdReserva.Text);
                VeterinarioDAO.ActualizaReserva(txtRut.Text, txtIdReserva.Text, txtVeterinario.Text);
                Response.Redirect("Inicio.aspx");
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('Reserva confirmada con éxito", true);
            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('Error, problemas para confirmar la reserva, intente nuevamente.", true);
            }

        }
    }
}