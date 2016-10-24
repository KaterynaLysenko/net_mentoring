namespace HashTableImpl
{
    internal class HashTableNode
    {
        public int hash { get; set; }
        public object key { get; set; }
        public object value { get; set; }
        public HashTableNode next { get; set; }
    }

}
