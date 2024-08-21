using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    internal class CustomList<T> : IEnumerable
    {
        public CustomList() : this(0) { }

        public CustomList(int capacity)
        {
            if (capacity < 0)
            {
                throw new ArgumentException("Capacity should be bigger than zero");
            }
            _data = new T[capacity];
            Count = _data.Length;
        }

        public CustomList(ICollection<T> collection)
        {
            if (collection == null)
            {
                throw new ArgumentException("Provided collection is null");
            }

            Count = collection.Count;
            Capacity = Count;
            _data = new T[Count];
            collection.CopyTo(_data, 0);
        }

        private T[] _data;
        public int Capacity { get; set; }
        public int Count { get; private set; }

        public void Add(T item)
        {
            ManageCapacity();
            _data[Count] = item;
            Count++;
        }

        public void Remove(T item)
        {
            int index = Array.IndexOf(_data, item);
            RemoveAt(index);
        }

        public void RemoveAt(int index)
        {
            if (index >= Count)
                throw new IndexOutOfRangeException();

            Count--;
            if (index < Count)
            {
                Array.Copy(_data, index + 1, _data, index, Count - index);
            }
            _data[Count] = default(T);
        }

        public void Insert(int index, T item)
        {
            if (index > Count)
                throw new IndexOutOfRangeException();
            if (index == Count)
                ManageCapacity();

            Array.Copy(_data, index, _data, index + 1, Count - index);
            _data[index] = item;
            Count++;
        }

        private void ManageCapacity()
        {
            if (Capacity <= Count)
            {
                T[] newData = new T[Capacity * 2];
                Capacity *= 2;
                _data.CopyTo(newData, 0);
                _data = newData;
            }
        }

        private bool Contains(T item)
        {
            return _data.Contains(item);
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < Count; i++)
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
