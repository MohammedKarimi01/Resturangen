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
                for (int j = 0; j < peoplePerGroup; j++)
                {
                    Console.WriteLine(Guests[counter].Name + " " + grpSize);
                    //Console.WriteLine(LobbyGroups[counter].Name + " " + grpSize);
                    //LobbyGroups.Add(Guests[counter]);
                    grpSize++;
                    counter++;
                }
                grpSize = 1;
                
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
        //Ropa hit waiters.
        //Ropa hit gäster.
        //Waiters kollar storlek på grupp
        //Waitters kollar om det finns plats för grupp
        //Om det finns, släng in om det inte finns plats stoppa i kö.
    }

}
