using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HospitalRegistrationApp
{
    internal class utils
    {
        public static Dictionary<int, string> getSlots()
        {
            Dictionary<int,string> slots = new Dictionary<int,string>();
            slots.Add(1, "9:00-9:30");
            slots.Add(2, "9:30-10:00");
            slots.Add(3, "10:00-10:30");
            slots.Add(4, "10:30-11:00");
            slots.Add(5, "11:00-11:30");
            return slots;
           
        }
        


    }
}
