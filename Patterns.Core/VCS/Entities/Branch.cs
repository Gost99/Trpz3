
using Patterns.Core.Iterator;
using Patterns.Core.Iterator.Interfaces;

namespace Patterns.Core.VCS.Entities
{
    public class Branch
    {
        public string Name { get; set; }

        public IAggregate<Commit> Commits { get; set; }

        public override string ToString()
        {
            return "branch " + this.Name;
        }
    }
}
