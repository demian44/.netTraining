namespace API.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Api : DbContext
    {
        public Api()
            : base("name=Api1")
        {
        }

        public virtual DbSet<curso> cursos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<curso>()
                .Property(e => e.id)
                .HasPrecision(18, 0);

            modelBuilder.Entity<curso>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<curso>()
                .Property(e => e.price)
                .HasPrecision(18, 0);

            modelBuilder.Entity<curso>()
                .Property(e => e.hours)
                .HasPrecision(18, 0);

            modelBuilder.Entity<curso>()
                .Property(e => e.aimgUrl)
                .IsUnicode(false);
        }
    }
}
