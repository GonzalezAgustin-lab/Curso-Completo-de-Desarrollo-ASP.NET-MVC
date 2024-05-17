using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MiApp.Models
{
    public class Clientes
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaAlta { get; set; }
        public int Edad {  get; set; }
    }

    public class EmpDBContext : DbContext
    {
        public EmpDBContext()
        { }

        public DbSet<Clientes> Clientes { get; set; }
    }
}