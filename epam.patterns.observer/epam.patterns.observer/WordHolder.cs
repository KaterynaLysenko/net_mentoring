using System.Collections;
using System.Collections.Generic;

namespace epam.patterns.observer
{
    public class WordHolder : AbstractSubject
    {
        private string word;
        public string Word
        {
            get
            {
                return word;
            }
            set
            {
                word = value;
                this.Notify();
            }
        }
    }
}