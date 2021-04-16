using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace POO_LAB_Transporte
{
    public partial class EjercicioPOO1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                Random aleatorio = new Random();
                List<Transporte> transportes = new List<Transporte>();
                for (int i = 1; i < 6; i++)
                {
                    transportes.Add(new Avion(aleatorio.Next(1, 200)));
                    transportes.Add(new Automovil(aleatorio.Next(1, 5)));
                }

                int contAvion = 1;
                int contAutomovil = 1;

                foreach (var item in transportes)
                {

                    if (item.GetType() == typeof(Automovil))
                    {
                        lblResultadosAutomovil.Text += $"Automovil {contAutomovil}: " + item.GetPasajeros() + " pasajeros. </br>";
                        contAutomovil++;
                    }

                    if (item.GetType() == typeof(Avion))
                    {
                        lblResultadosAvion.Text += $"Avion {contAvion}: " + item.GetPasajeros() + " pasajeros. </br>";
                        contAvion++;
                    }

                    Session["lista"] = transportes; //para no perder los valores randoms 
                }
            }


        }


        protected void btnAvanzar_Click(object sender, EventArgs e)
        {
            List<Transporte> transports = (List<Transporte>)Session["lista"];
            lblAvanzarDetenerse.Text = transports[Convert.ToInt32(DropDownList1.SelectedValue)].Avanzar();
        }

        protected void btnDetenerse_Click(object sender, EventArgs e)
        {
            List<Transporte> transports = (List<Transporte>)Session["lista"];
            lblAvanzarDetenerse.Text = transports[Convert.ToInt32(DropDownList1.SelectedValue)].Detenerse();
        }
    }
}
