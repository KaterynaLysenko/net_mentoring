namespace epam.patterns.observer.simple
{
    public interface IHolder
    {
        void NotifyListeners();

        void AddListener(IListener listener);

        void RemoveListener(IListener listener);
    }
}