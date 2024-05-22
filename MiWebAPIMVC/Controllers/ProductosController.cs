using MiWebAPIMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MiWebAPIMVC.Controllers
{
    public class ProductosController : ApiController
    {
        Producto[] productos = new Producto[]
        {
            new Producto{Id=1, Nombre="P1", Categoria="C1", Precio=3 },
            new Producto{Id=2, Nombre="P2", Categoria="C2", Precio=3 },
            new Producto{Id=3, Nombre="P3", Categoria="C3", Precio=3 }
        };
        public IEnumerable<Producto> GetProductos() { return productos; }
        public IHttpActionResult GetProducto(int id) 
        {
            var producto = productos.FirstOrDefault(x => x.Id == id);
            if (producto == null)
            {
                return NotFound();
            }
            return Ok(producto);
        }

    }
}
