using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testFooDbContext.Models
{
    public class FooItems
    {
        public long Id { get; set; }
        public Guid Guid { get; set; }
        public string Name { get; set; }
        public FooItems() {
            Guid = System.Guid.NewGuid();
        }
    }
}
