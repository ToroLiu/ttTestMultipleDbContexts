using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testAppDbContext.Models
{
    public class AppItems
    {
        public long Id { get; set; }
        
        public Guid Guid { get; set; }
        public string Name { get; set; }

        public AppItems() {
            Guid = System.Guid.NewGuid();
        }
    }
}
