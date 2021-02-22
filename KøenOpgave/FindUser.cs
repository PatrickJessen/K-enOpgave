using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KøenOpgave
{
    class FindUser
    {
        //find a user in guestlist by user input
        public string FindUserByName(List<Guest> guestList, string userinput)
        {
            //loops through guestlist to check if the name the user enterd exists in the list
            for (int i = 0; i < guestList.Count; i++)
            {
                if (guestList[i].Name == userinput)
                {
                    return $"Name: {guestList[i].Name}, Age: {guestList[i].Age}, Arrived at: {guestList[i].TimeArrived}";
                }
            }
            return $"{userinput} was not found";
        }

        public string FindAllUsers(List<Guest> guestList)
        {
            //finds all users in the list
            string temp = "";
            for (int i = 0; i < guestList.Count; i++)
            {
                temp += $"Name: {guestList[i].Name}, Age: {guestList[i].Age}, Arrived at: {guestList[i].TimeArrived} \n";
            }
            return temp;
        }
    }
}
