using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace epam.patterns.observer
{
    class SampleData
    {
        private static string[] words = new string[] { "cat", "dog", "mouse", "racoon", "quit", "fox" };
        public static List<string> getNext()
        {
            List<string> list = new List<string>();
            foreach (string word in words)
            {
                list.Add(word);
            }
            return list;
        }
    }
}
