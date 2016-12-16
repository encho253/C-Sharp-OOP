namespace Generic
{
    using Generic;
    using System;

    public class GenericList<T>
    {
        const int DefaultSize = 1;
        private int index;

        public GenericList()
        {
            this.ListArray = new T[DefaultSize];
            this.index = -1;
        }

        public T[] ListArray { get; private set; }

        public T this[int index]
        {
            get
            {
                return this.ListArray[index];
            }
            set
            {
                if (this.index < 0 || this.index > this.ListArray.Length)
                {
                    throw new IndexOutOfRangeException();
                }
                this.ListArray[index] = value;
            }
        }

        private void ResizeArray(int size)
        {
            var newList = new T[this.ListArray.Length + size];

            for (int i = 0; i <= this.ListArray.Length - 1; i++)
            {
                if (newList.Length > i)
                {
                    newList[i] = this.ListArray[i];
                }
                else
                {
                    break;
                }              
            }

            this.ListArray = newList;
        }

        public void Add(T element)
        {
            index++;

            if (index == this.ListArray.Length)
            {
                ResizeArray(1);
            }

            this.ListArray[index] = element;
        }

        public void RemoveAt(int index)
        {
            int j = 1;

            if (index > this.ListArray.Length || index < 0)
            {
                throw new IndexOutOfRangeException();
            }
            else
            {
                for (int i = 0; i < this.ListArray.Length; i++)
                {
                    if (i != index)
                    {
                        this.ListArray[j - 1] = this.ListArray[i];
                        j++;                 
                    }
                    else
                    {
                        continue;                       
                    }
                }
            }
            ResizeArray(-1);
        }
    }
}
