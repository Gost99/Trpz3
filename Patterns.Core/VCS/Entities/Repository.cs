
using Patterns.Core.Iterator;
using Patterns.Core.Iterator.Interfaces;

namespace Patterns.Core.VCS.Entities
{
    public class Repository
    {
        public string Name { get; set; }

        public IAggregate<Branch> Branches { get; set; }
    }
}
