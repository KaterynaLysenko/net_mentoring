using System;

namespace epam.patterns.observer.simple
{
    public class AllWordsListener : IListener
    {
        public void Update(string word)
        {
            Console.WriteLine("LISTENER 1: Subject has new word: {0}", word);
        }
    }
}
