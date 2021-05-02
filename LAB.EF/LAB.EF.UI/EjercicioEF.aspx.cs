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
    public partial class EjercicioEF : System.Web.UI.Page
    {
        protected EmployeesLogic employeesLogic = new EmployeesLogic();

        protected TerritoriesLogic territoriesLogic = new TerritoriesLogic();
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void btnListEmpleados_Click(object sender, EventArgs e)
        {
            ListBox1.Items.Clear();
            lblLista.Text = "Empleados";
            foreach (Employees employee in employeesLogic.GetAll())
            {
                ListBox1.Items.Add(employee.FullName);
            }
        }

        protected void btnListTerritorios_Click(object sender, EventArgs e)
        {
            ListBox1.Items.Clear();
            lblLista.Text = "Territorios";
            foreach (Territories territorie in territoriesLogic.GetAll())
            {
                ListBox1.Items.Add($"{territorie.TerritoryID} - {territorie.TerritoryDescription}");
            }
        }
    }
}