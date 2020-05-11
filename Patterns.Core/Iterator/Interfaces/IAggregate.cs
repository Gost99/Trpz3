
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Patterns.Core.Iterator.Interfaces
{
    public interface IAggregate<TEntity>
    {
        IIterator<TEntity> CreateIterator();

        IList<TEntity> Items { get; }

        void Add(TEntity entity);
    }
}
