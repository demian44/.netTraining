using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVC.CODEFIRST.Models
{
    public class Student
    {
        [Key]
        public int EstudentID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public int Average { get; set; }
        public string Email { get; set; }

        // PROPERTY of NAVIGATION
        //1 Student can has n matriculas

        public virtual ICollection<Enrollment> Enrollments { get; set; }

        //public List<Enrollment> Enrollments { get; set; }
    }
}