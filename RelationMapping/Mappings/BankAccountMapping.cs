using System.Data.Entity.ModelConfiguration;
using RelationMapping.Entities;

namespace RelationMapping.Mappings
{
    public class BankAccountMapping : EntityTypeConfiguration<BankAccount>
    {
        public BankAccountMapping()
        {
            Property(x => x.BankName)
                .HasColumnName("bankName");

            Property(x => x.Swift)
                .HasColumnName("swift");

            Map(x => x.MapInheritedProperties().ToTable("BankAccount"));
        }
    }
}
