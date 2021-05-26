using LAB.Entities;
using LAB.Logic;
using LAB.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LAB.MVC.Controllers
{
    public class EmployeesController : Controller
    {
        EmployeesLogic employeeLogic = new EmployeesLogic();
        // GET: Employees
        public ActionResult Index()
        {
            try
            {
                List<Entities.Employees> employees = employeeLogic.GetAll();

                List<EmployeesView> employeesViews = employees.Select(s => new EmployeesView
                {
                    Id = s.EmployeeID,
                    FullName = s.FullName
                }).ToList();

                return View(employeesViews);
            }
            catch (Exception ex)
            {
                TempData["message"] = ex.Message;
                return RedirectToAction("Index", "Error");
            }
        }
        public ActionResult Insert(int id = -1)
        {
            try
            {
                List<SelectListItem> list = new List<SelectListItem>();
                list.Add(new SelectListItem { Value = "", Text = "Ninguno" });
                foreach (var item in employeeLogic.GetAll())
                {
                    SelectListItem campo = new SelectListItem();
                    campo.Value = item.EmployeeID.ToString();
                    campo.Text = item.FullName;
                    list.Add(campo);
                }
                ViewBag.DDReports = list;
                TempData["DDREPORTS"] = ViewBag.DDReports;

                EmployeesView employeesView = new EmployeesView();
                if (id != -1) //si es distinto de -1 es update (se manda el modelo al view, sino se manda vacio)
                {
                    var employee = employeeLogic.GetOne(id);

                    #region ********REGION ASIGNACIONES********

                    employeesView.Id = employee.EmployeeID;
                    employeesView.LastName = employee.LastName;
                    employeesView.FirstName = employee.FirstName;
                    employeesView.Address = employee.Address;
                    employeesView.BirthDate = employee.BirthDate;
                    employeesView.City = employee.City;
                    employeesView.Country = employee.Country;
                    employeesView.HireDate = employee.HireDate;
                    employeesView.Extension = employee.Extension;
                    employeesView.HomePhone = employee.HomePhone;
                    employeesView.Notes = employee.Notes;
                    employeesView.PhotoPath = employee.PhotoPath;
                    employeesView.PostalCode = employee.PostalCode;
                    employeesView.Region = employee.Region;
                    employeesView.Title = employee.Title;
                    employeesView.ReportsTo = employee.ReportsTo;
                    employeesView.TitleOfCourtesy = employee.TitleOfCourtesy;

                    #endregion

                    return View(employeesView);
                }
                return View();
            }
            catch (Exception ex)
            {
                TempData["message"] = ex.Message;
                return RedirectToAction("Index", "Error");
            }
        }


        [HttpPost]
        public ActionResult Insert(EmployeesView employeesView)
        {
            ViewBag.DDReports = TempData["DDREPORTS"];
            if (ModelState.IsValid)
            {
                var errors = ModelState.Values.SelectMany(v => v.Errors);
                try
                {
                    {
                        var employeeEntity = new Employees();

                        #region ********REGION ASIGNACIONES********

                        employeeEntity.LastName = employeesView.LastName;
                        employeeEntity.FirstName = employeesView.FirstName;
                        employeeEntity.Address = employeesView.Address;
                        if (employeesView.BirthDate != null)
                            employeeEntity.BirthDate = employeesView.BirthDate;
                        employeeEntity.City = employeesView.City;
                        employeeEntity.Country = employeesView.Country;
                        if (employeesView.HireDate != null)
                            employeeEntity.HireDate = employeesView.HireDate;
                        employeeEntity.Extension = employeesView.Extension;
                        employeeEntity.HomePhone = employeesView.HomePhone;
                        employeeEntity.Notes = employeesView.Notes;
                        employeeEntity.PhotoPath = employeesView.PhotoPath;
                        employeeEntity.PostalCode = employeesView.PostalCode;
                        employeeEntity.Region = employeesView.Region;
                        employeeEntity.ReportsTo = employeesView.ReportsTo;
                        employeeEntity.Title = employeesView.Title;
                        employeeEntity.TitleOfCourtesy = employeesView.TitleOfCourtesy;

                        #endregion

                        if (employeesView.Id == 0)
                            employeeLogic.Add(employeeEntity);
                        else
                        {
                            employeeEntity.EmployeeID = employeesView.Id;
                            employeeLogic.Update(employeeEntity);
                        }
                        return RedirectToAction("Index");
                    }
                }

                catch (Exception ex)
                {
                    TempData["message"] = ex.Message;
                    return RedirectToAction("Index", "Error");
                }
            }
            return View(employeesView);
        }

        public ActionResult Delete(int id)
        {
            try
            {
                employeeLogic.Delete(id);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                TempData["message"] = ex.Message;
                return RedirectToAction("Index", "Error");
            }
        }
    }
}