using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Create_a_custom_linked_list
{
    internal class CustomLinkedList<T>
    {
        public Node<T>? First { get; set; }
        public int Count { get; set; }

        public void Add(T value)
        {
            Node<T> newNode = new Node<T>(value);
            if (First != null)
            {
                First.Next = newNode;
                First.Next.Previous = First;
            }
            else
            {
                First = newNode;
            }
            Count++;
        }

        public IEnumerator<Node<T>> GetEnumerator()
        {
            Node<T>? Current = First;

            while (Current != null)
            {
                yield return Current;
                Current = Current.Next;
            }
        }
    }
}
