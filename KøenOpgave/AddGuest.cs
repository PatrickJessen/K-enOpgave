using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KøenOpgave
{
    class AddGuest
    {
        CheckForLimit limit = new CheckForLimit();
        //adds new guest to the list as long as its not full
        public string AddNewGuest(List<Guest> guestList, string userinput, int ageinput)
        {
            if (limit.IsMaxLimitReached(guestList) == true)
            {
                return "Max limit of guests is reached you cant add more!";
            }
            guestList.Add(new Guest(userinput, ageinput, DateTime.Now));
            return $"Added new guest";
        }
    }
}
