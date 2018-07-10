using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SchoolWeb.Models
{
    /// <summary>
    /// El contexto representa la base de datos
    /// </summary>
    public class SchoolContext : DbContext
    {
        // Es posible utilizar la sobre carga de la clase base
        // para indicar el nombre de una cadena de conexión en particular
        // public SchoolContext() : base("MiCadenaConexion") { }


        /// <summary>
        /// Cada DbSet representa tablas en la base de datos
        /// </summary>
        
        public DbSet<Course> Course { get; set; }
        public DbSet<Student> Student { get; set; }
    }
}