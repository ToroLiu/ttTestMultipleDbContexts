using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using testAppDbContext.Models;

namespace testFooDbContext.Models
{
    public class FooDbContext : BaseDbContext
    {
        public DbSet<FooItems> FooItems { get; set; }

        static FooDbContext() {
            Database.SetInitializer(new FooDbContextInitializer());
        }
        public FooDbContext() : base() { }
    }

    public class FooDbContextInitializer : CreateDatabaseIfNotExists<FooDbContext> {
        protected override void Seed(FooDbContext context)
        {
            base.Seed(context);
        }
    }
}
