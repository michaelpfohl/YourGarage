using System;
using System.Collections.Generic;
using System.Text;

namespace YourGarage.Vehicles.Watercraft
{
    class Jetski : WatercraftBase
    {
        public override void Drive()
        {
            Console.WriteLine($"The jetski does sick flips and tricks off the wake.");
        }
    }
}
