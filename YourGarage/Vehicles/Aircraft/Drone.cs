using System;
using System.Collections.Generic;
using System.Text;

namespace YourGarage.Vehicles.Aircraft
{
    class Drone : AircraftBase
    {
        public override void Fly()
        {
            Console.WriteLine($"The drone carries out unconstitutional strikes that violate the Geneva convention and soil the hands of the President.");
        }
    }
}
