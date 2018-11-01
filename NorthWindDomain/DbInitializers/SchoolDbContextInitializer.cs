using System.Data.Entity;
using NorthWindDomain.Entities;

namespace NorthWindDomain.DbInitializers
{
    public class SchoolDbContextInitializer : DropCreateDatabaseIfModelChanges<SchoolDbContext>
    {
        protected override void Seed(SchoolDbContext context)
        {
            var standards = new[] {
                new Standard { StandardName = "1st Standard" },
                new Standard { StandardName = "2nd Standard" },
                new Standard { StandardName = "3rd Standard" },
                new Standard { StandardName = "4th Standard" },
                new Standard { StandardName = "5th Standard" }
            };

            context.Standards.AddRange(standards);

            base.Seed(context);
        }
    }
}
