using System;

namespace _12.ADTStack
{
    public class DynamicStack<T> where T : struct
    {
        private T?[] _array;
        private int _topPosition;
        private int _top;

        public DynamicStack()
        {
            this._array = new T?[2];
            this.TopPosition = 0;
        }

        public int Count
        {
            get
            {
                return this._array.Length;
            }
        }

        public T? Peek()
        {
            return this._array[this.TopPosition - 1];
        }

        public int TopPosition
        {
            get { return this._topPosition; }
            private set { this._topPosition = value; }
        }

        public T? Top
        {
            get
            {
                if (this.TopPosition == 0)
                {
                    return this._array[this.TopPosition];
                }
                else
                {
                    return this._array[this.TopPosition - 1];
                }
            }
            private set
            {
                this._array[this._top] = value;
            }
        }

        public T? Pop()
        {
            var last = this._array[this.TopPosition - 1];
            this.TopPosition--;
            this._array[this.TopPosition] = default(T);
            return last;
        }
        public bool Contains(T item)
        {
            if (Array.IndexOf(this._array, item) > -1)
            {
                return true;
            }

            return false;
        }

        public void Push(T item)
        {
            if (this.TopPosition >= this.Count)
            {
                Array.Resize(ref this._array, this.Count * 2);
            }

            this._array[this.TopPosition] = item;
            this.TopPosition++;
        }

        public void Clear()
        {
            this._array = new T?[10];
            this.TopPosition = 0;
        }
    }
}
