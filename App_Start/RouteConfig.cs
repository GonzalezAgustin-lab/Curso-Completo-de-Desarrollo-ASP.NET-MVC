﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MiApp
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                "Clientes",
                "Clientes",
                defaults: new { controller = "Clientes", action = "Index", nombre = UrlParameter.Optional }
                );

            routes.MapRoute(
                "Proveedores",
                "Proveedores",
                defaults: new { controller = "Proveedores", action = "TodosLosProveedores", nombre = UrlParameter.Optional }
                );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
