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
        private CustomLinkedList<int>? _next;
        private int _number;

        private CustomLinkedList() { }
        public CustomLinkedList(int number)
        {
            _number = number;
        }

        public void Add(int number)
        {
            _next = new CustomLinkedList<int>(number);

        }

        public bool Contains(CustomLinkedList<int> list)
        {
            throw new NotImplementedException();
        }

        public void Remove(CustomLinkedList<int> list)
        {
            throw new NotImplementedException();
        }

        IEnumerator<CustomLinkedList<int>> GetEnumerator()
        {
            yield return new CustomLinkedList<int>();
        }
    }
}
