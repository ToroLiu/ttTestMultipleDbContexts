﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace testAppDbContext.Models
{
    public class AppDbContext : BaseDbContext
    {
        public DbSet<AppItems> Items { get; set; }

        static AppDbContext() {
            Database.SetInitializer(new AppDbContextInitializer());
        }
        public AppDbContext() : base() { }
    }

    public class AppDbContextInitializer : CreateDatabaseIfNotExists<AppDbContext> {
        protected override void Seed(AppDbContext context)
        {
            base.Seed(context);
        }
    }
}
