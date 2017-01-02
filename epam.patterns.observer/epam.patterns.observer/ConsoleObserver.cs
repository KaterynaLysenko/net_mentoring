using System;

namespace epam.patterns.observer
{
    public class ConsoleObserver : AbstractObserver
    {

        private WordHolder DataSource { get; set; }
        public ConsoleObserver(WordHolder subj)
        {
            this.DataSource = subj;
            subj.AddObserver(this);
        }
        public override void Update()
        {
            string word = DataSource.Word;
            if (word == "quit")
            {
                Console.WriteLine("Word 'quit' is detected!");
            }
        }
    }
}