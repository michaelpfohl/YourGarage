using System;
using System.Collections.Generic;
using System.Text;

namespace YourGarage.Vehicles.Watercraft
{
    class PontoonBoat : WatercraftBase
    {
        public override void Drive()
        {
            Console.WriteLine($"The pontoon boat carries a horde of partiers around the lake.");
        }
    }
}
