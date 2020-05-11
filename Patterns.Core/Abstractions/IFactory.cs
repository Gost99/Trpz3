namespace Patterns.Core.Abstractions
{
    public interface IFactory<TResult>
    {
        TResult Create();
    }
}
