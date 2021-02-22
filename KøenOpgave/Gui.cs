using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KøenOpgave
{
    class Gui
    {
        Guest guest = new Guest();
        List<Guest> guests = new List<Guest>();
        string userinput;
        AddGuest add = new AddGuest();
        DeleteGuest delete = new DeleteGuest();
        FindUser find = new FindUser();
        public void MainMenu()
        {
            Console.WriteLine("1. Add guest");
            Console.WriteLine("2. Delete guest");
            Console.WriteLine("3. Show number of guests");
            Console.WriteLine("4. Show max number of guests");
            Console.WriteLine("5. Find guest");
            Console.WriteLine("6. Find all guests");
            Console.WriteLine("7. Exit");
        }

        public void HandleMenu()
        {
            while (true)
            {
                Console.Clear();
                MainMenu();
                userinput = Console.ReadLine();
                switch (int.Parse(userinput))
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine(add.AddNewGuest(guests, Console.ReadLine(), int.Parse(Console.ReadLine())));
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine(delete.DeleteGuestFromList(guests, Console.ReadLine()));
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine($"There is {guests.Count} guests");
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine($"There can be maximum {guest.MaxLimit} guests");
                        Console.ReadKey();
                        break;
                    case 5:
                        Console.Clear();
                        Console.WriteLine(find.FindUserByName(guests, Console.ReadLine()));
                        Console.ReadKey();
                        break;
                    case 6:
                        Console.Clear();
                        Console.WriteLine(find.FindAllUsers(guests));
                        Console.ReadKey();
                        break;
                    case 7:
                        Environment.Exit(1);
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
