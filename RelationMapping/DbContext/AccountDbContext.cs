using System.Data.Entity;
using RelationMapping.Configuration;
using RelationMapping.Entities;
using RelationMapping.Mappings;

namespace RelationMapping
{
    public class AccountDbContext : DbContext
    {
        public AccountDbContext() : base("SchoolDbConnection")
        {
            Database.SetInitializer<AccountDbContext>(new AccountDbInitializer());
        }

        public DbSet<BillingDetail> BillingDetails { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations
                .Add(new BillingDetailMapping())
                .Add(new CreditAccountMapping())
                .Add(new BankAccountMapping());
        }
    }
}
