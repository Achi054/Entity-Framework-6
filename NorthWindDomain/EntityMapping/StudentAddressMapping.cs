using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using NorthWindDomain.Entities;

namespace NorthWindDomain.EntityMapping
{
    public class StudentAddressMapping : EntityTypeConfiguration<StudentAddress>
    {
        public StudentAddressMapping()
        {
            ToTable("studentAddress");

            HasKey(x => x.StudentAddressId);

            Property(x => x.StudentAddressId)
                .HasColumnName("studentAddressId");

            Property(x => x.Address)
                .HasColumnName("address");

            Property(x => x.State)
            .HasColumnName("state");

            Property(x => x.Country)
            .HasColumnName("country");

            Property(x => x.Zipcode)
            .HasColumnName("zipcode")
            .HasColumnType("varchar");
        }
    }
}
