
namespace Patterns.Core.VCS.Entities
{
    public class Commit
    {
        public string Hash { get; set; }

        public string Message { get; set; }

        public Commit Parent { get; set; }

        public override string ToString()
        {
            return "commit hash: " + this.Hash;
        }
    }
}
