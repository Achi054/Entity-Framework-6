using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using NorthWindDomain.Entities;

namespace NorthWindDomain.EntityMapping
{
    public class CourseMapping : EntityTypeConfiguration<Course>
    {
        public CourseMapping()
        {
            ToTable("course");

            HasKey(x => x.CourseId);

            Property(x => x.CourseId)
                .HasColumnName("courseId")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.CourseName)
                .HasColumnName("courseName");
        }
    }
}
