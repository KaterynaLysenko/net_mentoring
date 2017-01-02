using System.Collections.Generic;

namespace epam.patterns.observer.simple
{
    public class WordHolder : IHolder
    {
        private string word;

        private List<IListener> listeners = new List<IListener>();

        public string Word
        {
            get { return word; }
            set
            {
                word = value;
                NotifyListeners();
            }
        }

        public void NotifyListeners()
        {
            foreach (var listener in listeners)
            {
                listener.Update(word);
            }
        }

        public void AddListener(IListener listener)
        {
            listeners.Add(listener);
        }

        public void RemoveListener(IListener listener)
        {
            listeners.Remove(listener);
        }
    }
}
