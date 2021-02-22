using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KøenOpgave
{
    class CheckForLimit
    {
        //Check if we're above 10 in guestlist, if we are above return true
        public bool IsMaxLimitReached(List<Guest> guestList)
        {
            if (guestList.Count > 10)
            {
                return true;
            }
            return false;
        }
    }
}
