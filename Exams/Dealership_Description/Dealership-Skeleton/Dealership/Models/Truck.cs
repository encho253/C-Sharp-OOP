namespace Dealership.Models
{
    using System;
    using Contracts;

    public class Truck : ITruck
    {
        public int WeightCapacity
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }
}