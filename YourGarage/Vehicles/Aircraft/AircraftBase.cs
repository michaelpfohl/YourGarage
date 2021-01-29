using System;
using System.Collections.Generic;
using System.Text;

namespace YourGarage.Vehicles.Aircraft
{
    class AircraftBase : VehicleBase
    {
        public virtual void Fly()
        {
            Console.WriteLine($"The {GetType().Name} soars through the air");
        }
    }
}
