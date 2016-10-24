namespace Epam.Collections
{
    internal class HashTableNode
    {
        public int Hash { get; set; }
        public object Key { get; set; }
        public object Value { get; set; }
        public HashTableNode Next { get; set; }
    }

}
