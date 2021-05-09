using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LAB.MVC.Models
{
    public class EmployeesView
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        [Required(ErrorMessage = "Este campo es requerido.")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Este campo es requerido.")]
        public string FirstName { get; set; }
        public string Title { get; set; }
        public string TitleOfCourtesy { get; set; }

        [DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:dd.MM.yy}", ApplyFormatInEditMode = true)]
        [Display(Name = "este campo")]
        public DateTime? BirthDate { get; set; }

        [DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:dd.MM.yy}", ApplyFormatInEditMode = true)]
        [Display(Name = "este campo")]
        public DateTime? HireDate { get; set; }

        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string HomePhone { get; set; }
        public string Extension { get; set; }
        public string Notes { get; set; }
        public int? ReportsTo { get; set; }
        public string PhotoPath { get; set; }
    }

}