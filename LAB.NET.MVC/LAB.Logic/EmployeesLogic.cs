using LAB.Data;
using LAB.Logic;
using LAB.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB.Logic
{
    public class EmployeesLogic : BaseLogic, IABMLogic<Employees>
    {
        public List<Employees> GetAll()
        {
                return context.Employees.ToList();
        }

        public Employees GetOne(int id)
        {
            var employeeSelect = context.Employees.Find(id);
            return employeeSelect;
        }
        public void Add(Employees newEmployee)
        {
                context.Employees.Add(newEmployee);
                context.SaveChanges();
     
        }

        public void Delete(int id)
        {

                var employeeAEliminar = context.Employees.Find(id);
                context.Employees.Remove(employeeAEliminar);
                context.SaveChanges();

        }

        public void Update(Employees upT)
        {

                var employeeUpdate = context.Employees.Find(upT.EmployeeID);

                employeeUpdate.Address = upT.Address;
                employeeUpdate.BirthDate = upT.BirthDate;
                employeeUpdate.City = upT.City;
                employeeUpdate.Country = upT.Country;
                employeeUpdate.Extension = upT.Extension;
                employeeUpdate.FirstName = upT.FirstName;
                employeeUpdate.HireDate = upT.HireDate;
                employeeUpdate.HomePhone = upT.HomePhone;
                employeeUpdate.LastName = upT.LastName;
                employeeUpdate.Notes = upT.Notes;
                employeeUpdate.Photo = upT.Photo;
                employeeUpdate.PhotoPath = upT.PhotoPath;
                employeeUpdate.PostalCode = upT.PostalCode;
                employeeUpdate.Region = upT.Region;
                employeeUpdate.ReportsTo = upT.ReportsTo;
                employeeUpdate.Title = upT.Title;
                employeeUpdate.TitleOfCourtesy = upT.TitleOfCourtesy;

                context.SaveChanges();
        }

        public bool Exists(string idStr = "", int idInt = 0)
        {
            var employee = context.Territories.Find(idInt);
            if (employee != null)
                return true;
            else return false;
        }
    }
}
