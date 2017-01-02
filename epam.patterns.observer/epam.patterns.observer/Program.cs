using System;

namespace epam.patterns.observer
{
    public class Program
    {
        static void Main(string[] args)
        {
            WordHolder subj = new WordHolder();
            ConsoleObserver consObs = new ConsoleObserver(subj);

            foreach (var s in SampleData.getNext())
            {
                Console.WriteLine(s);
                subj.Word = s;
            }

            Console.ReadKey();
        }
    }
}
