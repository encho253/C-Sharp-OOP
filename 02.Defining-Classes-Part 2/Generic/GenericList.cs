namespace Generic
{
    using System;
    using System.Text;

    public class GenericList<T> where T : IComparable
    {
        private const int DefaultSize = 1;
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

        public void Add(T element)
        {
            this.index++;

            if (this.index == this.ListArray.Length)
            {
                this.ResizeArray(1);
            }

            this.ListArray[this.index] = element;
        }

        public void RemoveAt(int indexNumber)
        {
            int j = 1;
            this.index--;

            if (indexNumber > this.ListArray.Length || indexNumber < 0)
            {
                throw new IndexOutOfRangeException();
            }
            else
            {
                for (int i = 0; i < this.ListArray.Length; i++)
                {
                    if (i != indexNumber)
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

            this.ResizeArray(-1);
        }

        public void Clear()
        {
            var nullArray = new T[0];
            this.ListArray = nullArray;
            this.index = -1;
        }

        public int IndexOf(T value)
        {
            int valueIndex = -1;

            for (int i = 0; i < this.ListArray.Length; i++)
            {
                if (value.ToString() == this.ListArray[i].ToString())
                {
                    valueIndex = i;
                    break;
                }
            }

            return valueIndex;
        }
       
        public T Min()
        {
            T min = this.ListArray[0];

            for (int i = 0; i < this.ListArray.Length; i++)
            {
                if (min.CompareTo(this.ListArray[i]) > 0)
                {
                    min = this.ListArray[i];
                }
            }

            return min;
        }

        public T Max()
        {
            T max = this.ListArray[0];

            for (int i = 0; i < this.ListArray.Length; i++)
            {
                if (max.CompareTo(this.ListArray[i]) < 0)
                {
                    max = this.ListArray[i];
                }
            }

            return max;
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();

            foreach (var item in this.ListArray)
            {
                builder.Append(item).Append("\r\n");
            }

            return builder.ToString();
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
    }
}
