namespace Interview.Services.Patterns.Observer
{
    public interface IObservable
    {
        /// <summary>
        /// Удаляем наблюдателя
        /// </summary>
        /// <param name="o"></param>
        void RemoveObserver(IObserver o);

        void NotifyObservers();

        /// <summary>
        /// Регистрируем наблюдателя у себя
        /// </summary>
        /// <param name="o"></param>
        void RegisterObserver(IObserver o);
    }
}
