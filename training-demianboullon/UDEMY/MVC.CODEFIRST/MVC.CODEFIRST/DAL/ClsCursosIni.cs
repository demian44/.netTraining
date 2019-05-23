using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using MVC.CODEFIRST.Models;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace MVC.CODEFIRST.DAL
{
    public class ClsCursosIni : System.Data.Entity.DropCreateDatabaseIfModelChanges<CursoContext>
    {
        // Method seed to init data
        protected override void Seed(CursoContext objContext)
        {
            base.Seed(objContext);
            // STUDENT LIST
            var LstStudents = new List<Student>
            {
               new Student
               {
                  Name = "ASTRID CAROLINA",
                  Surname = "Brown",
                  Age = 21,
                  Average = 9,
                  Email = "ASTRID@Gmail.com",
                  EstudentID = 0
               },
               new Student
               {
                   Name = "Coso Cosito",
                   Surname = "Yellow",
                  Age = 19,
                  Average = 5,
                  Email = "Coso@Gmail.com",
                  EstudentID = 1
               }
            };

            LstStudents.ForEach(reg => objContext.Student.Add(reg));
            objContext.SaveChanges();

            // Enrollment DATA
            var LstEnrollment = new List<Enrollment>
            {
                new Enrollment
                {
                    DateEnrollment = DateTime.Parse("2018-10-10"),
                    EnrollmentID = 1001,
                    EstudentID = 1,
                },
                new Enrollment
                {
                    DateEnrollment = DateTime.Parse("2018-10-15"),
                    EnrollmentID = 1002,
                    EstudentID = 2,
                },
            };
            LstEnrollment.ForEach(reg => objContext.Enrollment.Add(reg));
            objContext.SaveChanges();
        }
    }
}