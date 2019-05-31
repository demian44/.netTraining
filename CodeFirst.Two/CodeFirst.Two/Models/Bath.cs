using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirst.Two.Models
{
    [Table("Baths")]
    public class Bath : BaseEntity
    {
        [Key]
        public Guid Id { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}")]
        public DateTime Date { get; set; }

        public float Price { get; set; }

        [ForeignKey("DogId")]
        public Dog Dog { get; set; }
    }
}
