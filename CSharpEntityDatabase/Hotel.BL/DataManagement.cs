using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEntityDatabase.Hotel.BL
{
    public static class DataManagement
    {

        // Didn't end up using this, still good for futre use tho. 
        public static bool EmptyStringCheck(string text)
        {
            if (text.Trim().Length == 0)
            {
                return false;

            }
            return true;
        }
    }


   



}