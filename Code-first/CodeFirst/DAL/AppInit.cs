using System;
using System.Collections.Generic;
using System.Data.Entity;
using CodeFirst.Models;

namespace CodeFirst.DAL
{
    public class AppInit : DropCreateDatabaseIfModelChanges<AppContext>
    {
        protected override void Seed(AppContext context)
        {
            base.Seed(context);

            context.DbStudent.AddRange(new List<Student>
            {
                new Student
                {
                    Age = 12,
                    Average = 10f,
                    Id = 0,
                    Mail = "Pepe@pepe.com",
                    Name = "Pepe",
                    Surname = "Coso"
                },
                new Student
                {
                    Age = 22,
                    Average = 1.5f,
                    Id = 1,
                    Mail = "Cerafia@pepe.com",
                    Name = "Cerafia",
                    Surname = "Coso"
                },
                new Student
                {
                    Age = 15,
                    Average = 6.3f,
                    Id = 2,
                    Mail = "Manuel@pepe.com",
                    Name = "Manuel",
                    Surname = "Cosito"
                },
            });

            context.DbEnrollment.AddRange(new List<Enrollment>
            {
                new Enrollment
                {
                    Date = new DateTime(2019, 03, 10),
                    Id = Guid.NewGuid(),
                    StudentId = 1
                },
                new Enrollment
                {
                    Date = new DateTime(2019, 03, 9),
                    Id = Guid.NewGuid(),
                    StudentId = 2
                },
            });

            context.SaveChanges();
        }
    }
}