namespace Observer
{
    public interface IObserver<T>
    {
        void Update(T value); //le paso el tipo generico T
    }
}