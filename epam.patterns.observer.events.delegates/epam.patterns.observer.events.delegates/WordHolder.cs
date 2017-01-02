namespace epam.patterns.observer.events.delegates
{
    public class WordHolder
    {
        public delegate void OnWordChanged(string word);

        public event OnWordChanged onWordChanged;
        
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
                onWordChanged(value);
            }
        }
    }
}
