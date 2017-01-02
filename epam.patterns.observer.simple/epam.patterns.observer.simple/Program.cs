using System;

namespace epam.patterns.observer.simple
{
    public class Program
    {
        static void Main(string[] args)
        {
            IListener listener1 = new AllWordsListener();
            IListener listener2 = new QuitWordListener();

            WordHolder subj = new WordHolder();
            subj.AddListener(listener1);
            subj.AddListener(listener2);

            subj.Word = "home";
            subj.Word = "office";
            subj.Word = "quit";

            Console.ReadKey();
        
        }
    }
}
