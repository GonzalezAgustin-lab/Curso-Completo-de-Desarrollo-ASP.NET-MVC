using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MiApp.Controllers
{
    public class ProveedoresController : Controller
    {
        // GET: Procesos
        public string TodosLosProveedores()
        {
            return @"<ul>
                    <li>Carrefour</li>
                    <li>Dia</li>
                    <li>De campo</li>
                    <li>Los Hermanos</li>
                    </ul>";
        }
    }
}