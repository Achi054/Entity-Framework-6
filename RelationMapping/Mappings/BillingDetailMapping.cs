using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using RelationMapping.Entities;

namespace RelationMapping.Mappings
{
    public class BillingDetailMapping : EntityTypeConfiguration<BillingDetail>
    {
        public BillingDetailMapping()
        {
            HasKey(x => x.BillingDetailId);

            Property(x => x.BillingDetailId)
                .HasColumnName("billingDetailId")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(x => x.Number)
                .HasColumnName("number");

            Property(x => x.Owner)
                .HasColumnName("owner");
        }
    }
}
