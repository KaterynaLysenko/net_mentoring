using System.Collections;

namespace Epam.Collections
{
    internal class LinkedListEnumerator : IEnumerator
    {
        ListNode currentNode;
        ListNode head;
        public LinkedListEnumerator(ListNode rootNode)
        {
            this.currentNode = rootNode.prev;
            head = rootNode;
        }
        public bool MoveNext()
        {
            if (currentNode == null)
            {
                currentNode = head;
                return true;
            }
            currentNode = currentNode.next;
            return currentNode != null;
        }

        public void Reset()
        {
            currentNode = head;
        }

        public object Current
        {
            get
            {
                return currentNode.item;
            }
        }
    }
}