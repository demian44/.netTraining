using CodeFirst.Two.Models;
using Microsoft.EntityFrameworkCore;

namespace CodeFirst.Two.Context
{
    public class CodeFirstTwoContext : DbContext
    {
        public CodeFirstTwoContext()
            :base()
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=DESKTOP-E0B40E5\SQLEXPRESS;Database=CodeFirstTwo;Integrated Security=True");
        }

        public DbSet<Bath> DbBaths { get; set; }

        public DbSet<Dog> DbDogs { get; set; }
    }
}
