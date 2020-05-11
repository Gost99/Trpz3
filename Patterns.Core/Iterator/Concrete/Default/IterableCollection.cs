
using Patterns.Core.Iterator.Interfaces;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Patterns.Core.Iterator
{
    public class IterableCollection<TEntity> : IAggregate<TEntity>
    {
        private readonly IList<TEntity> _internalCollection;

        public IList<TEntity> Items 
        { 
            get 
            {
                return this._internalCollection;
            } 
        }

        #region Ctors

        public IterableCollection()
        {
            this._internalCollection = new List<TEntity>();
        }

        #endregion

        public void Add(TEntity entity)
        {
            this._internalCollection.Add(entity);
        }

        public virtual IIterator<TEntity> CreateIterator()
        {
            return new AscendingIterator<TEntity>(this);
        }
    }
}
