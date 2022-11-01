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
            int nrOfGroups = 4;
            Random rnd = new Random();
            int peoplePerGroup = 0;
            
            while (true)
            {
                peoplePerGroup = rnd.Next(1, 5);
                for (int i = 0; i < nrOfGroups; i++)
                {

                    string[] groupOne = new string[peoplePerGroup];
                    int personCount = 0;
                    for (int j = i; j < names.Length; j += nrOfGroups)
                    {
                        groupOne[personCount] = names[j] + " - " + j;
                        personCount++;
                    }

                    Array.Sort(groupOne);
                    for (int k = 0; k < personCount; k++)
                    {
                        Console.WriteLine(groupOne[k]);
                    }
                    Console.WriteLine();
                }
            }
            
            
        }








        //public static int GetGroupsize()
        //{
        //    int Groupsize = 0;
        //    Random rnd = new Random();
        //    Groupsize = rnd.Next(1, 5);

        //    return Groupsize;

        //}
        //public static List<Group> MakeGroups()
        //{
        //    List<Group> groups = new List<Group>();
        //    groups.Add(new Group(Groupsize));
        //    return groups;
        //}
        //public static void PrintGroups(List<Group> groups)
        //{
        //    Console.WriteLine(groups);
        //}
        //public Restaurant(int groupsize)
        //{
        //    Groupsize = groupsize;
        //}

    }



}
