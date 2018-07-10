using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDemo.Model
{
    public class EFDemoContext : DbContext
    {
        // public EFDemoContext() : base("MyConnectionString") { }

        public DbSet<Student> Student { get; set; }
        public DbSet<Course> Course { get; set; }
    }
}
