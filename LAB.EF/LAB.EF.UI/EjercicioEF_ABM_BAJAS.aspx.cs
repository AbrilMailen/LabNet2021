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
    public partial class Ejercicio_ABM_BAJAS : System.Web.UI.Page
    {
        protected EmployeesLogic employeeLogic = new EmployeesLogic();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                foreach (Employees employee in employeeLogic.GetAll())
                {
                    ListItem item = new ListItem();
                    item.Value = employee.EmployeeID.ToString();
                    item.Text = employee.FullName;
                    ddEmpleadosBajas.Items.Add(item);
                }
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            if (ddEmpleadosBajas.SelectedValue != "null")
            {
                try
                {
                    employeeLogic.Delete(Convert.ToInt32(ddEmpleadosBajas.SelectedValue));
                    lblEstado.Text = "Proceso completado con exito.";
                    ddEmpleadosBajas.SelectedItem.Enabled = false;
                }
                catch(Exception ex)
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "alert", $"alert('{ex.Message} El elemento esta relacinado con otro, por lo tanto es imposible realizar la baja.')", true);
                    lblEstado.Text = "";
                }
               
            }
        }
    }
}