using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Autenticacion.Controllers
{
    [Authorize(Users = "prueba@hola.com")]
    public class AccesoController : Controller
    {
        // GET: Acceso
        public ContentResult Privado()
        {
            return Content("Privado");
        }

        [AllowAnonymous]
        public ContentResult Publico()
        {
            return Content("Publico");
        }
    }
}