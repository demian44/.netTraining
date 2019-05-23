using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC.CODEFIRST.Models
{
    public class Enrollment
    {
        [Key]
        public int EnrollmentID { get; set; }
        public DateTime DateEnrollment { get; set; }
        public int EstudentID { get; set; }// Foranean Key

        public virtual Student MdlStudent { get; set; }
    }
}