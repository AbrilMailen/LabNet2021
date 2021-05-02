using LAB.EF.Entities;
using LAB.EF.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LAB.EF.UI
{
    public partial class EjercicioEF_ABM_BAJAS_T : System.Web.UI.Page
    {
        protected TerritoriesLogic territoriesLogic = new TerritoriesLogic();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                foreach (Territories territorie in territoriesLogic.GetAll())
                {
                    ListItem item = new ListItem();
                    item.Value = territorie.TerritoryID;
                    item.Text = territorie.TerritoryDescription;
                    ddTerritoriosBajas.Items.Add(item);
                }
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            if (ddTerritoriosBajas.SelectedValue != "null")
            {
                try
                {
                    territoriesLogic.Delete(ddTerritoriosBajas.SelectedValue);
                    lblEstado.Text = "Proceso completado con exito.";
                    ddTerritoriosBajas.SelectedItem.Enabled = false;
                }
                catch(Exception ex)
                {
                    ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", $"alert('{ex.Message} El elemento esta relacionado con otro, por lo tanto es imposible realizar la baja.')", true);
                    lblEstado.Text = "";
                }
            }
        }
    }
}