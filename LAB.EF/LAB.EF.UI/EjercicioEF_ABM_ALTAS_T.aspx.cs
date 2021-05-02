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
    public partial class EjercicioEF_ABM_ALTAS_T : System.Web.UI.Page
    {
        protected TerritoriesLogic territoriesLogic = new TerritoriesLogic();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAgregarTerritorio_Click(object sender, EventArgs e)
        {
            Territories territorie = new Territories();

            territorie.RegionID = Convert.ToInt32(ddRegion.SelectedValue);
            territorie.TerritoryDescription = txtDescription.Text;
            territorie.TerritoryID = txtID.Text;

            try
            {
                territoriesLogic.Add(territorie);
                lblEstado.Text = "Proceso completado con exito.";
            }
            catch { lblEstado.Text = "El ID Territorio ingresado ya esta en uso, pruebe con otro."; }

        }
    }
}