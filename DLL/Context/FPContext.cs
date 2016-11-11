using DLL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL.Context
{
    public class FPContext : DbContext
    {
        public FPContext() : base("FinalProject")
        {
            Database.SetInitializer(new DbInitializer());
        }

        public virtual DbSet<Company> Companies { get; set; }
        public virtual DbSet<Group> Groups { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Project> Projects { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Company>().HasMany<Project>(p => p.Projects).WithRequired(c => c.Company);
            modelBuilder.Entity<Group>().HasOptional<Project>(p => p.Project);
            modelBuilder.Entity<User>().HasOptional<Company>(c => c.Company);
            base.OnModelCreating(modelBuilder);
        }
    }
}
