using System;

namespace Epam.Collections
{
    public class MyHashTable : IHashTable
    {
        private const int initialCapacity = 100;

        private int capacity = initialCapacity;
        private HashTableNode[] buckets;

        public MyHashTable(int capacity)
        {
            buckets = new HashTableNode[capacity];
        }

        public MyHashTable()
        {
            buckets = new HashTableNode[capacity];
        }

        private int Compress(int hasCode)
        {
            return Math.Abs(hasCode % capacity); ;
        }
       
        private int Hash(object key)
        {
            return Compress(key.GetHashCode());
        }

        public object this[object key]
        {
            get
            {
                return FindEllement(key).Value;
            }

            set
            {
                if (!Contains(key))
                {
                    Add(key, value);
                }
                else
                {
                    FindEllement(key).Value = value;
                }
                
            }
        }

        public bool Contains(object key)
        {
            int hashOfKey = Hash(key);
            if (buckets[hashOfKey] == null)
            {
                return false;
            }

            // + TODO: code dupl.
            return GetNodeByKey(key) != null;
        }

        public void Add(object key, object value)
        {
            int hashOfKey = Hash(key);
            if (Contains(key))
            {
                throw new ElementAlreadyPresentException();
            }
            HashTableNode newNode = new HashTableNode();
            newNode.Hash = hashOfKey;
            newNode.Key = key;
            newNode.Value = value;
            HashTableNode current = buckets[hashOfKey];
            if (current == null)
            {
                buckets[hashOfKey] = newNode;
            }
            else
            {
                // - TODO: code dupl.?
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
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
            value = current.Value;
            return true;
            /*
            try
            {
                value = FindEllement(key);
            }
            catch (ElementNotPresentExeption e) {
                value = null;
                return false;
            }
            return true;
            */
        }

        private HashTableNode FindEllement(object key)
        {
            if (!Contains(key))
            {
                throw new ElementNotPresentExeption();
            }

            // + TODO: code duplication
            return GetNodeByKey(key);
        }

        private HashTableNode GetNodeByKey(object key)
        {
            int hashOfKey = Hash(key);
            HashTableNode current = buckets[hashOfKey];

            do
            {
                if (current.Key.Equals(key))
                {
                    return current;
                }
                current = current.Next;
            } while (current != null);

            return current;
        }
    }
}
