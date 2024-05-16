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

        /*public string Index() 
        {
            return "Este es mi controlador home";
        }*/

        public ActionResult MiVista()
        {
            return View();
        }

        /*[Authorize (Roles = "Admin")]
        [OutputCache (Duration = 10)]*/
        [ActionName("Hora")]
        public string HoraActual()
        {
            //return DateTime.Now.ToString("T");
            return CadenaHora();
        }

        [NonAction]
        public string CadenaHora()
        {
            return "Son las " + DateTime.Now.ToString("T");
        }

    }
}