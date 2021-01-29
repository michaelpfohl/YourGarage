using System;
using System.Collections.Generic;
using System.Text;

namespace YourGarage.Vehicles.Cars
{
    class Fiesta : CarBase
    {
        public override void Drive()
        {
            Console.WriteLine($"The Fiesta putzes along before dying on the side of the road.");
        }
    }
}
