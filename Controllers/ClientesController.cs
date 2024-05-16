using MiApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using MiApp.Models;

namespace MiApp.Controllers
{
    public class ClientesController : Controller
    {

        public ActionResult Index()
        {
            var Clientes = from e in TodosLosClientes()
                           orderby e.Id
                           select e;
            return View(Clientes);
        }

        public ActionResult Details() 
        { 
            return View();      
        }

        public ActionResult Create() 
        {
            return View();
        }

        [HttpPost] 
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Edit()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Delete()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        [NonAction]
        public List<Clientes> TodosLosClientes()
        {
            return new List<Clientes>
            {
                new Clientes
                {
                    Id = 1,
                    Nombre = "Agustin",
                    FechaAlta = DateTime.Parse(DateTime.Today.ToString()),
                    Edad = 30
                },
                new Clientes
                {
                    Id = 2,
                    Nombre = "Lilia",
                    FechaAlta = DateTime.Parse(DateTime.Today.ToString()),
                    Edad = 34
                },
            };
        }
        
        // GET: Procesos
        /*public ActionResult Buscar(string nombre)
        {
            var input = Server.HtmlEncode (nombre);
            return Content(input);
        }

        [HttpGet]
        public ActionResult Buscar()
        {
            var input = "Este es un selector HTTP Get";
            return Content(input);
        }*/
    }
}