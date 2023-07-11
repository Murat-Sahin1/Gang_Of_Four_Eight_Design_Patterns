using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gang_Of_Four_Eight_Design_Patterns.Behavioral_Design_Patterns.Iterator_Design_Pattern
{
    public class ListNode<T>
    {
        public T Value { get; set; }
        public ListNode<T> Next { get; set; }
    }
    // Name LinkedList was already taken
    public class Linked_List<T> : IEnumerable
    {
        public ListNode<T> Head { get; set; }
        public ListNode<T> Current { get; set; }
        public void Add(T value)
        {
            var newNode = new ListNode<T> { Value = value };
            if (Head != null) {
                var current = Head;
                while (current.Next != null) current = current.Next;
                current.Next = newNode;
            }
            else {
                Head = newNode;
            }
        }
        public IEnumerator GetEnumerator()
        {
            var current = Head;
            while (current != null) {
                yield return current.Value;
                current = current.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
