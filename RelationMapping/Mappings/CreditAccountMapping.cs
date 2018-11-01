using System.Data.Entity.ModelConfiguration;
using RelationMapping.Entities;

namespace RelationMapping.Mappings
{
    public class CreditAccountMapping : EntityTypeConfiguration<CreditAccount>
    {
        public CreditAccountMapping()
        {
            Property(x => x.CardType)
                .HasColumnName("cardType");

            Property(x => x.ExpiryMonth)
                .HasColumnName("expiryMonth");

            Property(x => x.ExpiryYear)
                .HasColumnName("expiryYear");

            Map(x => x.MapInheritedProperties().ToTable("CreditAccount"));
        }
    }
}
