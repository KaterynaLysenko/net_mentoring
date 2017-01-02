using System;

namespace epam.patterns.observer.events.delegates
{
    class Program
    {
        private static string[] words = new string[] { "cat", "dog", "mouse", "racoon", "quit", "fox" };

        static void Main(string[] args)
        {
            WordHolder wordHolder = new WordHolder();

            ConsoleListener consoleListener = new ConsoleListener();
            wordHolder.onWordChanged += consoleListener.CheckForQuit;

            foreach (string word in words)
            {
                Console.WriteLine(word);
                wordHolder.Word = word;
            }
        }
    }
}
