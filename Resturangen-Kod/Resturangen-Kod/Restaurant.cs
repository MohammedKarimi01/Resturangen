using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Resturangen_Kod
{
    internal class Restaurant
    {
        public List<Group> Groups = new List<Group>();
        public static string[] gruppledare = new string[30];
        //public static List<string> gruppledare;
        public static List<int> ints1 = new List<int>();
        public static List<int> bord1 = new List<int>();
        public static List<int> bord2 = new List<int>();
        public static int[] ints2;
        public static int Groupsize { get; set; }
        public static List<Person> CreatingGroups()
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
                    else if (counter >= Guests.Count)
                    {
                        Console.WriteLine("Slut på gäster");
                        break;
                    }

                    Console.WriteLine(Guests[counter].Name + " " + grpSize);

                    Console.WriteLine(Guests);
                    grpSize++;
                    counter++;
                }
                grpSize = 1;
                Console.WriteLine("------------------");
                //counter = 0;
                //string[] namn = new string[LobbyGroups.Count];
                //foreach (Person g in LobbyGroups)
                //{
                //    namn[counter] = g.Name;
                //    counter++;
                //}
                //GUI.Window.Draw("Bord " + i, 30, 5 * i, namn);
                //LobbyGroups.Clear();
                //List<int> ints = new List<int>();
                //grpSize -= 1;
                //ints.Add(grpSize);
                //grpSize = 1;
            }
            return Guests;

        }
        public static string[] CreatingGroupss()
        {
            string[] names = Person.GetNames();
            //List<Person> Guests = Person.CreatingGuests(names);
            List<Person> LobbyGroups = new List<Person>();
            Random rnd = new Random();

            int nrOfGroups = 30;
            int peoplePerGroup = 0;
            int counter = 0;
            int grpSize = 1;
            int r = 0;
            int test = 0;
            //Tar in Namn, skapar grupper på en random storlek, samt ger varje person en balance
            for (int i = 0; i < nrOfGroups; i++)
            {
                peoplePerGroup = rnd.Next(1, 5);
                Console.WriteLine();
                Console.WriteLine("Grupp: " + i);
                for (int j = 0; j < peoplePerGroup; j++)
                {
                    if (counter < names.Length)
                    {
                        if (j == 0)
                        {
                            gruppledare[r] = names[counter];
                            r++;
                        }
                        Console.WriteLine(names[counter] + " " + grpSize);
                        //Console.WriteLine(LobbyGroups[counter].Name + " " + grpSize);
                        //  LobbyGroups.Add(names[counter]);
                        grpSize++;
                        counter++;
                    }
                    else if (counter >= names.Length)
                    {
                        Console.WriteLine("Slut på gäster");
                        break;
                    }
                }
                // ints2[test] = grpSize;
                test++;
                List<int> ints = new List<int>();
                grpSize -= 1;
                ints1.Add(grpSize);
                grpSize = 1;
            }
            for (int i = 0; i < ints1.Count; i++)
            {
                if (ints1[i] <= 2)
                {
                    bord2.Add(i);
                }
            }
            for (int i = 0; i < bord2.Count; i++)
            {
                Console.WriteLine(bord2[i]);
            }
            Console.WriteLine("--------------------------------");
            for (int i = 0; i < ints1.Count; i++)
            {

                if (ints1[i] >= 3)
                {
                    bord1.Add(i);
                }
            }
            for (int i = 0; i < bord1.Count; i++)
            {
                Console.WriteLine(bord1[i]);
            }
            return names;
        }

    }

    public class Lobby
    {



        //public static void GroupCheck()
        //{
        //    List<Person> Waiters = Waiter.CreatingWaiter();
        //    List<Person> LobbyGroups = Restaurant.CreatingGroups();

        //    int GroupCheck = 0;

        //    for (int i = 0; i < LobbyGroups.Count; i++)
        //    {
        //        GroupCheck++;
        //    }

        //}
        //Ropa hit waiters. KLART
        //Ropa hit gäster. KLART
        //Waiters kollar storlek på grupp. KLART
        //Waitters kollar om det finns plats för grupp.
        //Om det finns, släng in om det inte finns plats stoppa i kö.
    }

}