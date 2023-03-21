using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taxi
{
    class Program
    {
        static void Main(string[] args)
        {
            //membuat objek taxi
            tugas taxi = new tugas();

            //pengesetan nilai properties
            taxi.Drivename = "Rama";
            taxi.OnDuty = true;
            taxi.NumPassenger = 5;

            //pemanggilan method
            taxi.Info();
            taxi.PickUpPassenger();
            taxi.DropoffPassenger();

            Console.ReadKey();
        }
    }
}
