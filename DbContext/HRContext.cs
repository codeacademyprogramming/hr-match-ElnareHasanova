using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using HR_match.Models;

namespace HR_match
{
    public class HRContext : DbContext 
    {
    public HRContext() : base("Server=DESKTOP-QL20RPD\\SQLEXPRESS;Database=HRContext;Trusted_Connection=True;") { }

        public DbSet<HR> HRs { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<CV> CVs { get; set; }
        public DbSet<Vacancie> Vacancies { get; set; }
    }
}
