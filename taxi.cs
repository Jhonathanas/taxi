using system;
using system.collections.generic;
using system.linq;
using system.text;
using system.threading.task;

namespace LatihanClassDanObject
{
    class program
    {
        static void Main(string{} args)
        {
            //membuat objek Taxi
            Taxi taxi = new Taxi();
            //pengesatan nilai properties
            taxi.DriverName = "Jono";
            taxi.OnDuty = true;
            taxi.NumPassenger =10;

            //pemanggilan method
            taxi.TaxiInfo();
            taxi.PickUpPassenger();
            taxi.DropOffPassenger();

            Console.ReadKey();
        }
    }