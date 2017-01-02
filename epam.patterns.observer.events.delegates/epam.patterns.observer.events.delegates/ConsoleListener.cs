using System;

namespace epam.patterns.observer.events.delegates
{
    public class ConsoleListener
    {
        public void CheckForQuit(string word)
        {
            if (word == "quit")
            {
                Console.WriteLine("Word 'quit' is detected!");
                Console.ReadLine();
            }
        }
    }
}