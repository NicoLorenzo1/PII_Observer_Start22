namespace Observer
{
    public interface ISubject<T> //de tipo generico 
    {
        void Subscribe(IObserver<T> observer);
        void Unsubscribe(IObserver<T> observer);
    }
}