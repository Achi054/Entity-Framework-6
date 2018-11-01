using System;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace NorthWindDomain.DbConventions
{
    public class DateTime2Convention : Convention
    {
        public DateTime2Convention()
        {
            this.Properties<DateTime>().Configure(t => t.HasColumnType("datetime2"));
        }
    }
}
