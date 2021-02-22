using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KøenOpgave
{
    class DeleteGuest
    {
        //Deletes a guest from list by user input
        public string DeleteGuestFromList(List<Guest> guestList, string userinput)
        {
            //loops through guestlist and deletes user if username entered by user is in the list.
            for (int i = 0; i < guestList.Count; i++)
            {
                if (guestList[i].Name == userinput)
                {
                    guestList.RemoveAt(i);
                    return $"{userinput} has been kicked out";
                }
            }
            return $"{userinput} was not found in the guest list";
        }
    }
}
