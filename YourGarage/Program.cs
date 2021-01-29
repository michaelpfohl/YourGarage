using System;
using System.Collections.Generic;
using YourGarage.Vehicles;
using YourGarage.Vehicles.Aircraft;
using YourGarage.Vehicles.Cars;
using YourGarage.Vehicles.Watercraft;

namespace YourGarage
{
    class Program
    {
        public static void Main()
        {
            // Build a collection of all vehicles that fly
            // With a single `foreach`, have each vehicle Fly()
            var _747 = new Boeing747();
            var drone = new Drone();
            var aircraft = new List<AircraftBase> { _747, drone};
            foreach (var ac in aircraft)
            {
                ac.Fly();
            }

            // Build a collection of all vehicles that operate on roads
            // With a single `foreach`, have each road vehicle Drive()
            var _4runner = new _4Runner();
            var fiesta = new Fiesta();
            var cars = new List<CarBase> {_4runner,fiesta };
            foreach (var car in cars)
            {
                car.Drive();
            }
            // Build a collection of all vehicles that operate on water
            // With a single `foreach`, have each water vehicle Drive()
            var pontoon = new PontoonBoat();
            var jetski = new Jetski();
            var watercraft = new List<WatercraftBase> {pontoon, jetski };
            foreach (var wc in watercraft)
            {
                wc.Drive();
            }
        }
    }
}
