using System.Collections.Generic;

namespace CodeFirst.Models
{
    public class Student
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public int Age { get; set; }

        public float Average { get; set; }

        public string Mail { get; set; }

        public IEnumerable<Enrollment> Enrollments { get; set; }
    }
}