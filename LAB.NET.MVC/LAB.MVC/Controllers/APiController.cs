
using LAB.Logic;
using LAB.MVC.Models;
using System.Collections.Generic;
using System.Web.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace LAB.MVC.Controllers
{
    public class APiController : Controller
    {
        // GET: APi
   
        public async Task<ActionResult> Index()
        {   //get all quotes
            var apiLogic = new APILogic();
            var quotes= await apiLogic.getQuotes();
            List<APIview> caracteres = (from item in quotes
                                        let apiView = new APIview
                                        {
                                            character = item.character,
                                            image = item.image,
                                            quote = item.quote
                                        }
                                        select apiView).ToList();
            return View(caracteres);
        }
    }
}