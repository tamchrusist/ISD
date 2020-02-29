using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISD_Generics
{
    class MyList<T> : IEnumerable<T>
    {
        T[] array = new T[0];
        public T this[int index]
        {
            get
            {
                return array[index];
            }
        }
        public void Add(T item)
        {
            T[] NewArray = new T[array.Length + 1];
            array.CopyTo(NewArray, 0);
            NewArray[array.Length] = item;
            array = NewArray;
        }
        public int Count
        {
            get { return array.Length; }
        }
        int position = -1;
        public object Current
        {
            get { return array[position]; }
        }

        public bool MoveNext()
        {
            if (position < array.Length - 1)
            {
                position++;
                return true;
            }
            else { Reset(); return false; }
        }
        public void Reset()
        {
            position = -1;
        }

        #region IEnumerable<T> Members

        public IEnumerator<T> GetEnumerator()
        {
            foreach (T item in array)
                yield return item;
        }
        #endregion

        #region IEnumerable Members

        IEnumerator IEnumerable.GetEnumerator()
        {
            return array.GetEnumerator();
        }

        #endregion
    }

    public static class StaticClass
    {
        public static T[] GetArray<T>(this IEnumerable<T> list)
        {
            int i = 0; T[] array = new T[i];
            foreach (T item in list)
            {
                T[] NewArray = new T[array.Length + 1];
                array.CopyTo(NewArray, 0);
                NewArray[array.Length] = item;
                array = NewArray;

            }
            return array;
        }
    }
}

