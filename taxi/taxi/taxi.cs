using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taxi
{
    public class tugas
    {
        public String Drivename { get; set; }
        public bool OnDuty { get; set; }
        public int NumPassenger { get; set; }

        public void Info()
        {
            Console.WriteLine("Nama: {0}", Drivename);
            if (OnDuty == true)
            {
                Console.WriteLine("On Duty: yes", OnDuty);
            }
            else if (OnDuty == false)
            {
                Console.WriteLine("On Duty: No", OnDuty);
            }
            Console.WriteLine("NumberPass: {0}", NumPassenger);
        }
        public void PickUpPassenger()
        {
            Console.WriteLine("{0} sedang menjemput penumpang", Drivename);
        }
        public void DropoffPassenger()
        {
            Console.WriteLine("{0} selesai mengantar penumpang", Drivename);
        }

    }

}
