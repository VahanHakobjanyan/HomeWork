using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomQueue
{
    internal class MyQueue<T> : IEnumerable<T>
    {
        public MyQueue() : this(0) { }

        public MyQueue(int capacity)
        {
            if (capacity < 0)
                throw new ArgumentException("Capacity should be bigger than zero");

            _data = new T[capacity];
            Count = _data.Length;
            _head = default(T);
            _tail = default(T);
        }

        public MyQueue(ICollection<T> collection)
        {
            if (collection == null)
                throw new ArgumentNullException();

            Count = collection.Count;
            _data = new T[Count];
            _capacity = Count;
            collection.CopyTo(_data, 0);
            _head = collection.ElementAt(0);
            _tail = collection.ElementAt(Count - 1);
        }

        private T[] _data;
        private int _capacity;
        public int Count { get; private set; }
        private T _head;
        private T _tail;

        public void Enqueue(T item)
        {
            if (_capacity <= Count)
            {
                ManageCapacity();
            }

            _data[Count] = item;
            Count++;
            UpdateTail();
        }

        public T Dequeue()
        {
            if (Count == 0)
                throw new System.ArgumentException("Empty queue");

            T itemToReturn = _head;
            _data[0] = default(T);

            for (int i = 0; i < Count; i++)
            {
                _data[i] = _data[i + 1];
            }

            _data[Count - 1] = default(T);
            Count--;
            _head = _data[0];

            return itemToReturn;
        }

        public T Peek()
        {
            return _head;
        }

        public void Clear()
        {
            Count = 0;
            _data = new T[Count];
            _head = default(T);
            _tail = default(T);
        }

        public bool Contains(T item)
        {
            return _data.Contains(item);
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

        private void UpdateTail()
        {
            if (Count == 1)
                _tail = _head;
            else
                _tail = _data[Count - 1];
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < Count; i++)
                yield return _data[i];
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}

