using System;
using System.Collections;

namespace Epam.Collections
{
    public class LinkedList : ILinkedList
    {
        private ListNode head;
        private ListNode tail;
        private int size;

        public int Length => size;

        public void Add(object item)
        {
            if (size == 0)
            {
                ListNode l1 = new ListNode(item, null, null);
                head = tail = l1;
                size++;
            }
            else
            {
                ListNode ln = new ListNode(item, null, tail);
                tail.next = ln;
                tail = ln;
                size++;
            }
        }

        public void AddAt(object item, int index)
        {
            if (index < 0 || index >= size)
            {
                throw new IndexOutOfRangeException();
            }
            if (size == 0)
            {
                Add(item);
            }
            else
            {
                ListNode currentNode = GetListNodeAt(index);
                ListNode ln = new ListNode(item, currentNode.prev, currentNode);
                
                if (currentNode == head)
                {
                    head = ln;
                    currentNode.prev = ln;
                }
                else
                {
                    currentNode.prev.next = ln;
                    currentNode.prev = ln;

                }
                size++;
            }
        }

        public object ElementAt(int index)
        {
            return GetListNodeAt(index).item;

        }

        public void Remove()
        {
            if (size == 0)
            {
                throw new IndexOutOfRangeException();
            }
            tail = tail.prev;
            if (tail != null)
            {
                tail.next = null;
            }
            size--;
        }

        public void RemoveAt(int index)
        {
            if (index < 0 || index > size - 1)
            {
                throw new IndexOutOfRangeException();
            }
            if (index == size + 1)
            {
                Remove();
            }
            if (index == 0)
            {
                ListNode ln = GetListNodeAt(index);
                ln.next.prev = null;
                head = ln.next;
                size--;
            }
            else
            {
                ListNode ln = GetListNodeAt(index);
                ln.next.prev = ln.prev;
                ln.prev.next = ln.next;
                size--;
            }
        }
        private ListNode GetListNodeAt(int index)
        {
            ListNode currentNode = head;
            for (int i = 0; i < index; i++)
            {
                currentNode = currentNode.next;
            }
            return currentNode;
        }
        
        IEnumerator IEnumerable.GetEnumerator()
        {
            return new LinkedListEnumerator(head);
        }

    }
}
