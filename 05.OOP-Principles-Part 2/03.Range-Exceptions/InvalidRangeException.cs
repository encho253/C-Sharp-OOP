namespace _03.Range_Exceptions
{
    using System;

    public class InvalidRangeException<T> : ApplicationException
    {
        public InvalidRangeException(string message,T startRange , T endRange)
            :base(message)
        {
            this.StartRange = startRange;
            this.EndRange = endRange;
        }

        public T StartRange { get; private set; }
        public T EndRange { get; private set; }
    }
}