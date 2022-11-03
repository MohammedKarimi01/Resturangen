using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resturangen_Kod
{
    internal class Restaurant
    {
        public static int Groupsize { get; set; }
        public static List<Group> Groups = new List<Group>();
        public static List<Person >CreatingGroups()
        {
            string[] names = Person.GetNames();
            List<Person> Guests = Person.CreatingGuests(names);
            List<Person> LobbyGroups = new List<Person>();
            Random rnd = new Random();

            int nrOfGroups = 30;
            int peoplePerGroup = 0;
            int counter = 0;
            int grpSize = 1;

            //Tar in Namn, skapar grupper på en random storlek, samt ger varje person en balance
            for (int i = 0; i < nrOfGroups; i++)
            {
                peoplePerGroup = rnd.Next(1, 5);
                Console.WriteLine();
                Console.WriteLine("Grupp: " + i);
                for (int j = 0; j < peoplePerGroup; j++)
                {

                    if (counter < Guests.Count)
                    { 
                    Console.WriteLine(Guests[counter].Name + " " + grpSize);
                    //Console.WriteLine(LobbyGroups[counter].Name + " " + grpSize);
                    LobbyGroups.Add(Guests[counter]);
                    grpSize++;
                    counter++;
                    }
                    else if(counter >= Guests.Count)
                    {
                        Console.WriteLine("Slut på gäster");
                        break;
                    }
                }
                List<int> ints = new List<int>();
                grpSize -= 1;
                ints.Add(grpSize);
                grpSize = 1;
                foreach (int item in ints)
                {
                    Console.WriteLine(item);

                }
            }
            return Guests;

        }

    }

    public class Lobby
    {

   

        public static void GroupCheck()
        {
            List<Person> Waiters = Waiter.CreatingWaiter();
            List<Person> LobbyGroups = Restaurant.CreatingGroups();

            int GroupCheck = 0;

            for (int i = 0; i < LobbyGroups.Count; i++)
            {
                GroupCheck++;
            }
            
        }
        //Ropa hit waiters. KLART
        //Ropa hit gäster. KLART
        //Waiters kollar storlek på grupp. KLART
        //Waitters kollar om det finns plats för grupp.
        //Om det finns, släng in om det inte finns plats stoppa i kö.
    }

}
