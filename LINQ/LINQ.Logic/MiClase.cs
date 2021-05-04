using LINQ.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.Logic
{
    public class MiClase
    {
        public string CompanyName { get; set; }
        public DateTime OrderDate { get; set; }
        public string Region { get; set; }
     
        public string IDCustomer { get; set; }
        public int  Ordenes { get; set; }
    }
}
