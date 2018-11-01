using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using NorthWindDomain.Entities;

namespace NorthWindDomain.EntityMapping
{
    public class StandardMapping : EntityTypeConfiguration<Standard>
    {
        public StandardMapping()
        {
            ToTable("standard");

            HasKey(x => x.StandardId);

            Property(x => x.StandardId)
                .HasColumnName("standardId")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.StandardName)
               .HasColumnName("standardName")
               .HasMaxLength(100)
               .IsRequired();
        }
    }
}
