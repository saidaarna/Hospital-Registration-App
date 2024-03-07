using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalRegistrationApp
{
    public class Hesab
    {
        int id, type;
        string name;
        public Hesab(int id, string name, int type)
        {
            this.id = id;
            this.name = name;
            this.type = type;
        }

        public override string ToString()
        {
            string account_type;
            if (type == 0)
            {
                account_type = "Resepsiyon";
            }
            else if(type == 1)
            {
                account_type = "Həkim";
            }
            else {
                account_type = "Pasiyent";
            }


            return account_type + ":"+ id.ToString()+"-"+name;
        }

        public int getId()
        {
            return id;
        }
    }
   
}
