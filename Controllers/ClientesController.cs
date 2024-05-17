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

        public static List<Clientes> empList = new List<Clientes>
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

        public ActionResult Index()
        {
            var Clientes = from e in empList
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
        public ActionResult Create(/*FormCollection collection*/ Clientes emp)
        {
            try
            {
                empList.Add(emp);
                /*Clientes emp = new Models.Clientes();
                emp.Nombre = collection["nombre"];
                DateTime jDate;
                DateTime.TryParse(collection["FechaAlta"], out jDate);
                emp.FechaAlta = jDate;
                string edad = collection["edad"];
                emp.Edad = Int32.Parse(edad);
                empList.Add(emp);*/
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Edit(int id)
        {
            List<Clientes> emList = TodosLosClientes();
            var Clientes = emList.Single(m => m.Id == id);
            return View(Clientes);
        }

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                var Clientes = empList.Single(m => m.Id == id);
                if (TryUpdateModel(Clientes))
                    return RedirectToAction("Index");
                return View(Clientes);
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