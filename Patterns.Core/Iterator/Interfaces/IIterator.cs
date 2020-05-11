
namespace Patterns.Core.Iterator.Interfaces
{
    public interface IIterator<TEntity>
    {
        TEntity First();

        bool Next();

        TEntity CurrentItem();
    }
}
