using LAB.Entities;
using LAB.Logic;
using LAB.NET.webAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LAB.NET.webAPI.Controllers
{
    public class EmployeesController : ApiController
    {
        public EmployeesLogic db = new EmployeesLogic();
        public IHttpActionResult Get()
        {
            try
            {
                var employeesView = db.GetAll().Select(e => new EmployeesView
                {
                    Id = e.EmployeeID,
                    LastName = e.LastName,
                    FirstName = e.FirstName,
                    Address = e.Address,
                    City = e.City,
                    Country = e.Country,
                    HomePhone = e.HomePhone,
                    PostalCode = e.PostalCode,
                    Region = e.Region,
                    Title = e.Title
                }).ToList();
                return Ok(employeesView);
            }
            catch {
                return InternalServerError();
            }
        }

        public IHttpActionResult Get(int id)
        {
            try
            {
                Employees e = db.GetOne(id);
                if (e != null)
                {
                    EmployeesView employeesView = new EmployeesView
                    {
                        Id = e.EmployeeID,
                        LastName = e.LastName,
                        FirstName = e.FirstName,
                        Address = e.Address,
                        City = e.City,
                        Country = e.Country,
                        HomePhone = e.HomePhone,
                        PostalCode = e.PostalCode,
                        Region = e.Region,
                        Title = e.Title
                    };
                    return Ok(employeesView);
                }
                else return NotFound();
            }
            catch {
                return InternalServerError();
            }
        }

        [HttpPost]
        public IHttpActionResult Post([FromBody] EmployeesView employee)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    Employees emp = new Employees
                    {
                        FirstName = employee.FirstName,
                        LastName = employee.LastName,
                        Title = employee.Title,
                        Address = employee.Address,
                        City = employee.City,
                        Region = employee.Region,
                        PostalCode = employee.PostalCode,
                        Country = employee.Country,
                        HomePhone = employee.HomePhone
                    };
                    db.Add(emp);
                    return Ok();
                }
                catch {
                    return InternalServerError();
                }
            }
            else return BadRequest(ModelState);
        }
        public IHttpActionResult Put([FromBody] EmployeesView employee)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    Employees emp = new Employees();
                    emp.EmployeeID = employee.Id;
                    emp.FirstName = employee.FirstName;
                    emp.LastName = employee.LastName;
                    emp.Title = employee.Title;
                    emp.Address = employee.Address;
                    emp.City = employee.City;
                    emp.Region = employee.Region;
                    emp.PostalCode = employee.PostalCode;
                    emp.Country = employee.Country;
                    emp.HomePhone = employee.HomePhone;
                    db.Update(emp);
                    return Ok();
                }
                catch {
                    return InternalServerError();
                }
            }
            else
                return BadRequest(ModelState);
        }
        public IHttpActionResult Delete(int id)
        {
            try
            {
                db.Delete(id);
                return Ok();
            }
            catch
            {
                return InternalServerError();
            }
        }
    }
}
