using System;
using System.Collections.Generic;
using System.Text;

namespace YourGarage.Vehicles.Cars
{
    class CarBase : VehicleBase
    {
        public virtual void Drive()
        {
            Console.WriteLine($"The {GetType().Name} drives down the road.");
        }
    }
}
