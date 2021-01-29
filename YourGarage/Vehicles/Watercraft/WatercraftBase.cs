using System;
using System.Collections.Generic;
using System.Text;

namespace YourGarage.Vehicles.Watercraft
{
    class WatercraftBase : VehicleBase
    {
        public virtual void Drive()
        {
            Console.WriteLine($"The {GetType().Name} glides through the water");
        }
    }
}
