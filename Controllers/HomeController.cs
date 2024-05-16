using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MiApp.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        /*public ActionResult Index()
        {
            return RedirectToAction("TodosLosProveedores", "proveedores");
        }*/

        public string Index() 
        {
            return "Este es mi controlador home";
        }

        [Authorize (Roles = "Admin")]
        [OutputCache (Duration = 10)]
        public string HoraActual()
        {
            return DateTime.Now.ToString("T");
        }

    }
}