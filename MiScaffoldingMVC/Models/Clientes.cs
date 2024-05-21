using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MiScaffoldingMVC.Models
{
    public class Clientes
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaAlta { get; set; }
        public int edad { get; set; }
    }

    public class EmpDBContext : DbContext
    {
        //DbSet<Clientes> Clientes { get; set; }

        public System.Data.Entity.DbSet<MiScaffoldingMVC.Models.Clientes> Clientes { get; set; }
    }
}