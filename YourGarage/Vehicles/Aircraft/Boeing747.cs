using System;
using System.Collections.Generic;
using System.Text;

namespace YourGarage.Vehicles.Aircraft
{
    class Boeing747 : AircraftBase
    {
        public override void Fly()
        {
            Console.WriteLine($"The 747 carries many passengers far distances.");
        }
    }
}
