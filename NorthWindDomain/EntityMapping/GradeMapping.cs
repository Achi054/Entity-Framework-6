using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using NorthWindDomain.Entities;

namespace NorthWindDomain.EntityMapping
{
    public class GradeMapping : EntityTypeConfiguration<Grade>
    {
        public GradeMapping()
        {
            ToTable("grade");

            HasKey(x => x.GradeId);

            Property(x => x.GradeId)
                .HasColumnName("gradeId")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.GradeName)
               .HasColumnName("gradeName");

            Property(x => x.Section)
               .HasColumnName("section");
        }
    }
}
