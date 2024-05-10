﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MiApp.Controllers
{
    public class ClientesController : Controller
    {
        // GET: Procesos
        public ActionResult Buscar(string nombre)
        {
            var input = Server.HtmlEncode (nombre);
            return Content(input);
        }
    }
}