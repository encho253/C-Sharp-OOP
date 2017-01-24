namespace Dealership.Models
{
    using System;
    using System.Collections.Generic;
    using Contracts;
    using Common.Enums;

    public class Vehicles : IVehicle, ICommentable, IPriceable
    {
        public IList<IComment> Comments
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public string Make
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public string Model
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public decimal Price
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public VehicleType Type
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public int Wheels
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }
}
