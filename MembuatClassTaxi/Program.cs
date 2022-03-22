﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembuatClassTaxi
{
    class Program
    {
        static void Main(string[] args)
        {
            //Membuat objek taxi
            Taxi taxi = new Taxi();

            //Pengesetan nilai properties
            taxi.DriverName = "KevinKun";
            taxi.OnDuty = true;
            taxi.NumPassenger = 10;

            //pemanggilan method
            taxi.InfoDriver();
            taxi.PickUpPassenger();
            taxi.DropOffPassenger();

            Console.ReadKey();
        }
    }
}
