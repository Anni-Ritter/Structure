using System;
using System.Collections;
using System.Collections.Generic;

namespace Structure
{
    class Stack<T>: IEnumerable<T>
    {
        private T[] items;
        private int count;
        const int number = 10;
        public Stack()
        {
            items = new T[number];
        }


        public bool IsEmpty
        {
            get { return count == 0; }
        }

        public int Count
        {
            get { return count; }
        }

        public void Push(T item)
        {
            if (count == items.Length)
                Resize(items.Length + 10);

            items[count++] = item;
        }

        public T Pop()
        {
            if (IsEmpty)
                throw new InvalidOperationException("Стек пуст");
            T item = items[--count];
            items[count] = default(T); 

            if (count > 0 && count < items.Length - 10)
                Resize(items.Length - 10);

            return item;
        }

        public T Peek()
        {
            return items[count - 1];
        }

        private void Resize(int max)
        {
            T[] tempItems = new T[max];
            for (int i = 0; i < count; i++)
                tempItems[i] = items[i];
            items = tempItems;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = this.Count - 1; i >= 0; i--)
            {
                yield return this.items[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
