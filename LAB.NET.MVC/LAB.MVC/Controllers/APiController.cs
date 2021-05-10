using LAB.Logic;
using LAB.MVC.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace LAB.MVC.Controllers
{
    public class APiController : Controller
    {
        // GET: APi
   
        public async Task<ActionResult> Index()
        {   //get all quotes
            var httpClient = new HttpClient();
            var json = await httpClient.GetStringAsync("https://futuramaapi.herokuapp.com/api/quotes");
            List<APIview> caracteres = JsonConvert.DeserializeObject<List<APIview>>(json);
            return View(caracteres);
        }
    }
}