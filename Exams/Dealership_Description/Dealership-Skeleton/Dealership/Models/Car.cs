namespace Dealership.Models
{
    using System;
    using Contracts;

    public class Car : ICar
    {
        public int Seats
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }
}