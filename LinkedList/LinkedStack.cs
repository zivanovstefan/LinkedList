using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class LinkedStack<T> : IEnumerable<T>
    {
        private readonly LinkedList<T> _linkedList = new LinkedList<T>();
        public bool IsEmpty => Count == 0;
        public int Count => _linkedList.Count;

        public void AddNode(T value)
        {
            _linkedList.AddLast(value);
        }
        public T Peek()
        {
            if (IsEmpty)
                throw new InvalidOperationException();
            return _linkedList.Last();
        }
        public void Print()
        {
            for (int count = _linkedList.Count; count > 0 ; count--)
                Console.WriteLine(count);
        }

        public IEnumerator<T> GetEnumerator()
        {
            return _linkedList.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
