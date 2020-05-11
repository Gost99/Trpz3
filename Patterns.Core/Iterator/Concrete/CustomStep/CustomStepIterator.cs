
using Patterns.Core.Iterator.Interfaces;

namespace Patterns.Core.Iterator
{
    public class CustomStepIterator<TEntity> : IIterator<TEntity>
    {
        private int _currentPosition = -1;

        private IAggregate<TEntity> _collection;

        private int _step;

        #region Ctors

        public CustomStepIterator(IAggregate<TEntity> collection, int step = 1)
        {
            this._collection = collection;
            this._step = step;
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
            int newPosition = this._currentPosition + 1 >= 0 ? this._currentPosition + this._step : this._currentPosition + 1;

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
