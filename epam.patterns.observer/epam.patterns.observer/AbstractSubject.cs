using System.Collections.Generic;

namespace epam.patterns.observer
{
    public abstract class AbstractSubject
    {
        List<AbstractObserver> observers = new List<AbstractObserver>();

        public void AddObserver(AbstractObserver observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(AbstractObserver observer)
        {
            observers.Remove(observer);
        }
        public void Notify()
        {
            foreach (var observer in observers)
            {
                observer.Update();
            }
       }
    }
}
