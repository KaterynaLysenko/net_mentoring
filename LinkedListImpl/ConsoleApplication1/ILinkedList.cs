using System.Collections;

namespace Epam.Collections
{
    public interface ILinkedList : IEnumerable
    {
        void Add(object item);
        void AddAt(object item, int index);
        object ElementAt(int index);
        void RemoveAt(int index);
    }
}