using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomStack
{
    internal class MyStack<T> : IEnumerable<T>
    {
        public MyStack() : this(0) { }
        public MyStack(int capacity)
        {
            if (capacity < 0)
                throw new ArgumentOutOfRangeException(nameof(capacity));

            Count = 0;
            _capacity = capacity;
            _data = new T[capacity];
        }
        public MyStack(ICollection<T> collection)
        {
            Count = collection.Count;
            _capacity = Count;
            _data = new T[Count];
            collection.CopyTo(_data, 0);
        }

        private T[] _data;
        private int _capacity;
        public int Count { get; private set; }

        public void Push(T item)
        {
            if (_capacity <= Count)
            {
                ManageCapacity();
            }

            _data[Count] = item;
            Count++;
        }

        public T Pop()
        {
            if (Count == 0)
                throw new System.ArgumentException("Empty stack");


            T itemToReturn = _data[Count - 1];
            _data[Count - 1] = default(T);
            Count--;
            return itemToReturn;

        }

        public T Peek()
        {
            if (Count == 0)
                throw new System.ArgumentException("Empty stack");

            return _data[Count - 1];
        }

        public bool Contains(T item)
        {
            for (int i = 0; i < Count; i++)
            {
                if (_data[i].Equals(item))
                    return true;
            }
            return false;
        }
        private void ManageCapacity()
        {
            if (_capacity <= Count)
            {
                T[] newData = new T[_capacity * 2];
                _capacity *= 2;
                _data.CopyTo(newData, 0);
                _data = newData;
            }
        }
        public IEnumerator<T> GetEnumerator()
        {
            for (int i = Count - 1; i >= 0; i--)
            {
                yield return _data[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
