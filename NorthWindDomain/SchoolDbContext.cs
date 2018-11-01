using System.Data.Entity;
using NorthWindDomain.DbConventions;
using NorthWindDomain.DbInitializers;
using NorthWindDomain.Entities;
using NorthWindDomain.EntityMapping;

namespace NorthWindDomain
{
    public class SchoolDbContext : DbContext
    {
        public SchoolDbContext():base("SchoolDbConnection")
        {
            Database.SetInitializer(new SchoolDbContextInitializer());
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Standard> Standards { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Add(new DateTime2Convention());
            modelBuilder.Configurations
                .Add(new StudentMapping())
                .Add(new StandardMapping())
                .Add(new StudentAddressMapping())
                .Add(new GradeMapping())
                .Add(new CourseMapping());
        }
    }
}
