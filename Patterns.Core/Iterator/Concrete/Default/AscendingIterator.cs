
using Patterns.Core.Iterator.Interfaces;

namespace Patterns.Core.Iterator
{
    public class AscendingIterator<TEntity> : IIterator<TEntity>
    {
        private int _currentPosition = -1;

        private IAggregate<TEntity> _collection;

        #region Ctors

        public AscendingIterator(IAggregate<TEntity> collection)
        {
            this._collection = collection;
        }

        #endregion


        public TEntity CurrentItem()
        {
            return this._collection.Items[this._currentPosition];
        }

        public TEntity First()
        {
            return this._collection.Items[0];
        }

        public bool Next()
        {
            int newPosition = this._currentPosition + 1;

            if (newPosition < this._collection.Items.Count)
            {
                this._currentPosition = newPosition;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
