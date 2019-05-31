using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using CodeFirst.Models;

namespace CodeFirst.DAL
{
    public class AppContext : DbContext
    {
        public AppContext() : base("ManagerSchool")
        {
        }

        public DbSet<Student> DbStudent { get; set; }
        public DbSet<Enrollment> DbEnrollment { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}