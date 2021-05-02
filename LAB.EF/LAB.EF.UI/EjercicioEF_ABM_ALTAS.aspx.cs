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
    public partial class EjercicioEF_ABM : System.Web.UI.Page
    {
        protected EmployeesLogic employeeLogic = new EmployeesLogic();

        protected void Page_Load(object sender, EventArgs e)
        {
            //cargar los datos para el campo de reportsTo de employees
            if (!IsPostBack)
            {
                ddReports.Items.Clear();
                ListItem itemNinguno = new ListItem();
                itemNinguno.Value = "null";
                itemNinguno.Text = "Ninguno";
                ddReports.Items.Add(itemNinguno);

                foreach (Employees employee in employeeLogic.GetAll())
                {
                    ListItem item = new ListItem();
                    item.Value = employee.EmployeeID.ToString();
                    item.Text = employee.FullName;
                    ddReports.Items.Add(item);
                }
            }
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            Employees employee = new Employees();

            employee.FirstName = txtNombre.Text;
            employee.LastName = txtApellido.Text;
            employee.Notes = txtNotas.Text;
            employee.Address = txtDireccion.Text;
            if ((dateNacimiento.Value) != "")
                if ((Convert.ToDateTime(dateNacimiento.Value)) < (DateTime.Now))
                    employee.BirthDate = Convert.ToDateTime(dateNacimiento.Value);
                else
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "alert", $"alert('La fecha de nacimiento no puede ser mayor a la fecha actual. Se le ha asignado un valor null.')", true);
                }
            if ((dateContratacion.Value) != "")
                employee.HireDate = Convert.ToDateTime(dateContratacion.Value);
            employee.HomePhone = txtTelefono.Text;
            employee.PostalCode = txtCP.Text;
            employee.Region = txtRegion.Text;
            employee.Title = txtTitulo.Text;
            employee.TitleOfCourtesy = ddCortesia.SelectedValue;
            employee.Extension = txtExtension.Text;
            employee.Photo = fileFoto.FileBytes; //cuando quiero subir una imagen deja de correr la pagina pero igual el filebytes ok
            employee.PhotoPath = txtPhotoPath.Text;
            employee.Country = txtPais.Text;
            if (ddReports.SelectedValue != "null") { employee.ReportsTo = Convert.ToInt32(ddReports.SelectedValue); }
            employee.City = txtCiudad.Text;


            try
            {
                employeeLogic.Add(employee);
                lblEstado.Text = "Proceso completado con exito.";
            }
            catch { lblEstado.Text = "Ocurrio un error"; }
        }
    }
}