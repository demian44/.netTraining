using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirst.Two.Models
{
    [Table("Dogs")]
    public class Dog : BaseEntity
    {
        [Key]
        public Guid Id { get; set; }

        [Column(TypeName = "NVARCHAR(50)")]
        [StringLength(50)]
        public string Name { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}")]
        public DateTime BirthDate { get; set; }

        [Column(TypeName = "NVARCHAR(50)")]
        [StringLength(50)]
        public string FatherName { get; set; }
    }
}
