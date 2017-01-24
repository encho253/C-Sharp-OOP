namespace Dealership.Models
{
    using System;
    using System.Collections.Generic;
    using Contracts;
    using Common.Enums;

    public class User : IUser
    {
        public string FirstName
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public string LastName
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public string Password
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public Role Role
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public string Username
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IList<IVehicle> Vehicles
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public void AddComment(IComment commentToAdd, IVehicle vehicleToAddComment)
        {
            throw new NotImplementedException();
        }

        public void AddVehicle(IVehicle vehicle)
        {
            throw new NotImplementedException();
        }

        public string PrintVehicles()
        {
            throw new NotImplementedException();
        }

        public void RemoveComment(IComment commentToRemove, IVehicle vehicleToRemoveComment)
        {
            throw new NotImplementedException();
        }

        public void RemoveVehicle(IVehicle vehicle)
        {
            throw new NotImplementedException();
        }
    }
}