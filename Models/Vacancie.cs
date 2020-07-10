using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_match.Models
{
    public class Vacancie
    {
        public Vacancie()
        {
            Employees = new List<Employee>();
        }

        [Key]
        public int Id { get; set; }
        [Required]
        public string VacancieName { get; set; }
        [Required]
        public string CompanyName { get; set; }
        [Required]
        public string Category { get; set; }
        public string Description { get; set; }
        [Required]
        public string City { get; set; }
        public int Salary { get; set; }
        public int Age { get; set; }
        public string Study { get; set; }
        public string WorkExperience { get; set; }
        [StringLength(13)]
        [Required]
        public string Mobile { get; set; }


        public int HrId { get; set; }
        public HR HR { get; set; }

        public ICollection<Employee> Employees { get; set; }

    }
}
