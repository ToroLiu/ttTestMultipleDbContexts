using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace testAppDbContext.Models
{
    public class BaseDbContext : DbContext
    {
        public BaseDbContext() : base("BaseDbContext") { }
    }
}
