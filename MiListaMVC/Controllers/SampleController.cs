using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MiListaMVC.Controllers
{
    public class SampleController : Controller
    {
        // GET: Sample
        public ActionResult Index()
        {
            List<string> lista = new List<string>();
            lista.Add("Seleccionar");
            lista.Add("Argentina");
            lista.Add("Bolivia");
            lista.Add("Colombia");

            SelectList Paises = new SelectList(lista);
            ViewData["Paises"] = Paises;
            return View();
        }

        public JsonResult Provincias(string Pais) 
        {
            List<string> ListProv = new List<string>();
            switch(Pais)
            {
                case "Argentina":
                    ListProv.Add("Buenos Aires");
                    ListProv.Add("Entre Rios");
                    break;
                case "Colombia":
                    ListProv.Add("Medellin");
                    ListProv.Add("Bogota");
                    break;
                case "Bolivia":
                    ListProv.Add("La Paz");
                    ListProv.Add("Santa Cruz");
                    break;
            }
            return Json(ListProv);
        }
    }
}