namespace Epam.Collections
{
    internal class ListNode
    {
        //OOP Incapsulation!
        public object item { get; set; }
        public ListNode next { get; set; }
        public ListNode prev { get; set; }

        public ListNode(object item, ListNode next, ListNode prev)
        {
            this.item = item;
            this.next = next;
            this.prev = prev;
        }
    }
}