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
    public partial class EjercicioEF_ABM_MODIFICACIONES_T : System.Web.UI.Page
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
                    ddTerritoriosModificaciones.Items.Add(item);
                }
        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            formularioModificaciones.Visible = true;
            var territorieSelected = territoriesLogic.GetOne(ddTerritoriosModificaciones.SelectedValue);

            ddRegion.SelectedValue = territorieSelected.RegionID.ToString();
            txtDescription.Text = territorieSelected.TerritoryDescription;
            txtID.Text = territorieSelected.TerritoryID;
            txtID.Enabled = false;

            Session["territorioUpdate"] = territorieSelected;
        }

        protected void btnCambiarTerritorio_Click(object sender, EventArgs e)
        {
            var territorioUpdate = (Territories)Session["territorioUpdate"];
            territorioUpdate.TerritoryDescription = txtDescription.Text;
            territorioUpdate.RegionID = Convert.ToInt32(ddRegion.SelectedValue);

            try
            {
                territoriesLogic.Update(territorioUpdate);
                lblEstado.Text = "Proceso completado con exito.";

            }
            catch { lblEstado.Text = "Ocurrio un error."; }
        }
    }
}