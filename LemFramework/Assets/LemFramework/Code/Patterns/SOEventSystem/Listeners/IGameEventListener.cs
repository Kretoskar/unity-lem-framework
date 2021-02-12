namespace LemFramework.Patterns.SOEventSystem
{
    public interface IGameEventListener<T> 
    {
        void OnEventRaised(T item);
    }
}
