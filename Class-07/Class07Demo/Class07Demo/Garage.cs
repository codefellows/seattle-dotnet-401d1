using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Class07Demo
{
    class Garage<T> : IEnumerable<T>
    {
        T[] items = new T[10];
        int count = 0;

        public void Add(T item)
        {
            items[count] = item;
            count++;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return items[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
           // throw new NotImplementedException();
        }
    }
}
