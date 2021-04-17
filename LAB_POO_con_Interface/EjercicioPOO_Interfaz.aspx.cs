using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LAB_POO_con_Interface
{
    public partial class EjercicioPOO_Interfaz : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                Random aleatorio = new Random();
                ArrayList transportes = new ArrayList();
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
                        Automovil Au;
                        Au = (Automovil) item;
                        lblResultadosAutomovil.Text += $"Automovil {contAutomovil}: " + Au.pasajeros + " pasajeros. </br>";
                        contAutomovil++;
                    }

                    if (item.GetType() == typeof(Avion))
                    {
                        Avion Av;
                        Av = (Avion)item;
                        lblResultadosAvion.Text += $"Avion {contAvion}: " + Av.pasajeros+ " pasajeros. </br>";
                        contAvion++;
                    }
                    Session["lista"] = transportes; //para no perder los valores randoms 
                }
            }


        }


        protected void btnAvanzar_Click(object sender, EventArgs e)
        {
            ArrayList transports = (ArrayList)Session["lista"];
            var objeto = transports[Convert.ToInt32(DropDownList1.SelectedValue)];
            if ((objeto.GetType()) == typeof(Avion)){
                Avion Av;
                Av = (Avion) objeto;
                lblAvanzarDetenerse.Text = Av.Avanzar();
            }
            else
            {
                Automovil Au;
                Au = (Automovil)objeto;
                lblAvanzarDetenerse.Text = Au.Avanzar();
            }

        }

        protected void btnDetenerse_Click(object sender, EventArgs e)
        {
            ArrayList transports = (ArrayList)Session["lista"];
            var objeto = transports[Convert.ToInt32(DropDownList1.SelectedValue)];
            if ((objeto.GetType()) == typeof(Avion))
            {
                Avion Av;
                Av = (Avion)objeto;
                lblAvanzarDetenerse.Text = Av.Detenerse();
            }
            else
            {
                Automovil Au;
                Au = (Automovil)objeto;
                lblAvanzarDetenerse.Text = Au.Detenerse();
            }
        }
    }
}
