using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_match.Models
{
    public class CV
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Study { get; set; }
        public string WorkExperience { get; set; }
        public string Category { get; set; }
        public string City { get; set; }
        public int MininumSalary { get; set; }
        [StringLength(13)]
        public string Mobile { get; set; }

        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
    }
}
