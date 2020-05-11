using Patterns.Core.Iterator.Interfaces;

namespace Patterns.Core.Iterator
{
    public class CustomStepCollection<TEntity> : IterableCollection<TEntity>
    {
        private int _step;

        public CustomStepCollection(int step): base()
        {
            this._step = step;
        }

        public override IIterator<TEntity> CreateIterator()
        {
            return new CustomStepIterator<TEntity>(this, _step);
        }
    }
}
