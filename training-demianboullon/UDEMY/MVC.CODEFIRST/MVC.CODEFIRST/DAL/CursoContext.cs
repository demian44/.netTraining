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
    public class CursoContext : DbContext
    {
        //Context
        public CursoContext(): base("CursosContext")
        {

        }

        // MODELS REFERENCE (Actualiza el modelo)
        public DbSet<Student> Student { get; set; }
        public DbSet<Enrollment> Enrollment { get; set; }

        // PLURAL CONVENTION
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}