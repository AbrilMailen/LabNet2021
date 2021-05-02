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
    public partial class EjercicioEF_ABM_MODIFICACIONES : System.Web.UI.Page
    {
        protected EmployeesLogic employeeLogic = new EmployeesLogic();

        protected void Page_Load(object sender, EventArgs e)
        {
            //cargar los datos en los drop down
            if (!IsPostBack)
            {
                foreach (Employees employee in employeeLogic.GetAll())
                {
                    ListItem item = new ListItem();
                    item.Value = employee.EmployeeID.ToString();
                    item.Text = employee.FullName;
                    ddReports.Items.Add(item);
                    ddEmpleadosModificaciones.Items.Add(item);
                }
            }
        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            var employeeSelected = employeeLogic.GetOne(Convert.ToInt32(ddEmpleadosModificaciones.SelectedValue)); //guardo el empleado a modificar y luego cargo los datos en el form
            Session["empleadoUpdate"] = employeeSelected;
            divFormularioModificaciones.Visible = true;
            #region
            txtApellido.Text = employeeSelected.LastName;
            txtNombre.Text = employeeSelected.FirstName;
            txtCiudad.Text = employeeSelected.City;
            if (employeeSelected.HireDate != null) lblContratacionOld.Text = employeeSelected.HireDate.Value.ToString("dd/MM/yyyy");
            txtCP.Text = employeeSelected.PostalCode;
            txtDireccion.Text = employeeSelected.Address;
            txtExtension.Text = employeeSelected.Extension;
            if (employeeSelected.BirthDate != null) lblNacimientoOld.Text = employeeSelected.BirthDate.Value.ToString("dd/MM/yyyy");
            txtNotas.Text = employeeSelected.Notes;
            txtPais.Text = employeeSelected.Country;
            txtPhotoPath.Text = employeeSelected.PhotoPath;
            txtRegion.Text = employeeSelected.Region;
            if (employeeSelected.ReportsTo == null)
                ddReports.SelectedValue = "null";
            else ddReports.SelectedValue = employeeSelected.ReportsTo.ToString();
            txtTelefono.Text = employeeSelected.HomePhone;
            txtTitulo.Text = employeeSelected.Title;
            ddCortesia.SelectedValue = employeeSelected.TitleOfCourtesy.ToString();
            #endregion
        }

        protected void btnCambiar_Click(object sender, EventArgs e)
        {
            var employeeUpdate = (Employees)Session["empleadoUpdate"];
            employeeUpdate.Address = txtDireccion.Text;
            if ((dateNacimiento.Value) != "")
                if ((Convert.ToDateTime(dateNacimiento.Value)) < (DateTime.Now))
                    employeeUpdate.BirthDate = Convert.ToDateTime(dateNacimiento.Value);
            employeeUpdate.City = txtCiudad.Text;
            employeeUpdate.Country = txtPais.Text;
            employeeUpdate.Extension = txtExtension.Text;
            employeeUpdate.FirstName = txtNombre.Text;
            if ((dateContratacion.Value) != "")
                employeeUpdate.HireDate = Convert.ToDateTime(dateContratacion.Value);
            employeeUpdate.HomePhone = txtTelefono.Text;
            employeeUpdate.LastName = txtApellido.Text;
            employeeUpdate.Notes = txtNotas.Text;
            employeeUpdate.PhotoPath = txtPhotoPath.Text;
            employeeUpdate.PostalCode = txtCP.Text;
            employeeUpdate.Region = txtRegion.Text;
            if (ddReports.SelectedValue != "null") { employeeUpdate.ReportsTo = Convert.ToInt32(ddReports.SelectedValue); }
            employeeUpdate.Title = txtTitulo.Text;
            employeeUpdate.TitleOfCourtesy = ddCortesia.SelectedValue;

            try
            {
                employeeLogic.Update(employeeUpdate);
                lblEstado.Text = "Proceso completado con exito.";
            }
            catch { lblEstado.Text = "Ocurrio un error."; }
        }
    }
}
