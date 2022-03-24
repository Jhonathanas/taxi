using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasTaxi
{
    class Program
    {
        static void Main(string[] args)
        {
            //membuat objek Taxi
            Taxi taxi = new Taxi();

            // pengesetan nilai properties
            taxi.DriverName = "Jono";

            //pemanggilan method
            taxi.TaxiInfo();

            if (taxi.OnDuty = true) 
            {
                taxi.PickUpPassenger(); //pemanggilan method jika taxi.OnDuty = true  
                taxi.NumPassenger = 10;
            } else {
                taxi.DropOffPassenger(); //pemanggilan method jika taxi.OnDuty = false 
            }

            Console.ReadKey();
        }
    }
}