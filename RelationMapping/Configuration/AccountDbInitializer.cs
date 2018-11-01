using System.Data.Entity;

namespace RelationMapping.Configuration
{
    public class AccountDbInitializer : DropCreateDatabaseAlways<AccountDbContext>
    {
        protected override void Seed(AccountDbContext context)
        {
            base.Seed(context);
        }
    }
}
