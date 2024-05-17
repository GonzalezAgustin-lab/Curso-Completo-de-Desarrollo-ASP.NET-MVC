using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace MiApp.Models
{
    public class Clientes
    {
        public int Id { get; set; }
        [StringLength(60, MinimumLength = 3)]
        public string Nombre { get; set; }

        [Display (Name = "Fecha de Alta")]
        [DataType (DataType.Date)]
        [DisplayFormat (DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]

        public DateTime FechaAlta { get; set; }

        [Range (18,75)]
        public int Edad {  get; set; }
    }

    public class EmpDBContext : DbContext
    {
        public EmpDBContext()
        { }

        public DbSet<Clientes> Clientes { get; set; }
    }
}