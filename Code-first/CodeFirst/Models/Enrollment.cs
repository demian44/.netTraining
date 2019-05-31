using System;
using System.ComponentModel.DataAnnotations;

namespace CodeFirst.Models
{
    public class Enrollment
    {
        public Guid Id { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}")]
        public DateTime Date { get; set; }

        public int StudentId { get; set; }

        public virtual Student Student { get; set; }
    }
}