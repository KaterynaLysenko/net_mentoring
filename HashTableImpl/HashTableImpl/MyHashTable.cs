using System;

namespace HashTableImpl
{
    public class MyHashTable : IHashTable
    {
        private static readonly int initialCapacity = 100;

        private int capacity = initialCapacity;
        private HashTableNode[] hashTable;

        public MyHashTable(int capacity)
        {
            hashTable = new HashTableNode[capacity];
        }

        public MyHashTable()
        {
            hashTable = new HashTableNode[capacity];
        }

       
        private int Hash(object key)
        {
            return Math.Abs(key.GetHashCode() % capacity);
        }

        public object this[object key]
        {
            get
            {
                return FindEllement(key).value;
            }

            set
            {
                FindEllement(key).value = value;
            }
        }

        public bool Contains(object key)
        {
            int hashOfKey = Hash(key);
            if (hashTable[hashOfKey] == null)
            {
                return false;
            }
            HashTableNode current = hashTable[hashOfKey];
            do
            {
                if (current.key.Equals(key))
                {
                    return true;
                }
                current = current.next;
            } while (current != null);

            return false;
        }

        public void Add(object key, object value)
        {
            int hashOfKey = Hash(key);
            if (Contains(key))
            {
                throw new SystemException();
            }
            HashTableNode newNode = new HashTableNode();
            newNode.hash = hashOfKey;
            newNode.key = key;
            newNode.value = value;
            HashTableNode current = hashTable[hashOfKey];
            if (current == null)
            {
                hashTable[hashOfKey] = newNode;
            }
            else
            {
                while (current.next != null)
                {
                    current = current.next;
                }
                current.next = newNode;
            }
        }
        public bool TryGet(object key, out object value)
        {
            if (!Contains(key))
            {
                value = null;
                return false;
            }
            HashTableNode current = FindEllement(key);
            value = current.value;
            return true;
        }

        private HashTableNode FindEllement(object key)
        {
            if (!Contains(key))
            {
                throw new SystemException();
            }
            int hashOfKey = Hash(key);
            HashTableNode current = hashTable[hashOfKey];
            do
            {
                if (current.key.Equals(key))
                {
                    return current;
                }
                current = current.next;
            } while (current != null);

            return current;
        }

    }
}
