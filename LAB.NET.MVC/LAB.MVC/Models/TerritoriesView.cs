using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LAB.MVC.Models
{
    public class TerritoriesView
    {
        [Required(ErrorMessage = "Este campo es requerido.") ]
        public string Id { get; set; }

        [Required(ErrorMessage = "Este campo es requerido.")]
        public string TerritoryDescription { get; set; }
        public int RegionID { get; set; }
    }
}