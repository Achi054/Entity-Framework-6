using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using NorthWindDomain.Entities;

namespace NorthWindDomain.EntityMapping
{
    public class StudentMapping : EntityTypeConfiguration<Student>
    {
        public StudentMapping()
        {
            ToTable("student");

            HasKey(x => x.StudentId);

            Property(x => x.StudentId)
                .HasColumnName("studentId")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.StudentName)
                .HasColumnName("studentName")
                .HasMaxLength(100)
                .IsRequired();

            HasOptional(x => x.Standard)
                .WithMany(x => x.Students)
                .HasForeignKey(x => x.StandardId);

            HasOptional(x => x.StudentAddress)
                .WithRequired(y => y.Student);

            HasRequired(x => x.Grade)
                .WithMany(y => y.Students)
                .HasForeignKey(z => z.GradeId);

            HasMany(x => x.courses)
                .WithMany(x => x.Students)
                .Map(x => x.MapLeftKey("studentId")
                .MapRightKey("courseId")
                .ToTable("course_student"));
        }
    }
}
