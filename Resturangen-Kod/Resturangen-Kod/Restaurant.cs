using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resturangen_Kod
{
    internal class Restaurant
    {
        public List<Group> Groups = new List<Group>();
        public static int Groupsize { get; set; }
        public static void CreatingGroups()
        {
            string[] names = Person.GetNames();
            List<Person> Guests = Person.CreatingGuests(names);
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
                    
                    Console.WriteLine(Guests);
                    grpSize++;
                    counter++;
                }
                grpSize = 1;
                Console.WriteLine("------------------");
            }



        }
       
    }



}
