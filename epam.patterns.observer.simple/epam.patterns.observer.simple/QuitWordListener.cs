using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace epam.patterns.observer.simple
{
    public class QuitWordListener : IListener
    {
        public void Update(string word)
        {
            if (word == "quit")
            {
                Console.WriteLine("LISTENER 2: Word 'quit' is detected");
            }
        }
    }
}
