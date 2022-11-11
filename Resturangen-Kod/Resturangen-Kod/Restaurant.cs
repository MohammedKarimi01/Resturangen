﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.Specialized;

namespace Resturangen_Kod
{
    public class Restaurant
    {
        public static List<Person> LobbyGroups = new List<Person>();
        public static Queue queueStora = new Queue();
        public static Queue queueLiten = new Queue();
        public static string[] allanamn = new string[30];
        public static string[] allanamnStora = new string[30];
        public static string[] allanamnLiten = new string[30];

        //public List<Group> Groups = new List<Group>();
        public List<Group> Groups = new List<Group>();
        public static string[] gruppledare = new string[30];
        public static List<int> ints1 = new List<int>();
        public static List<int> bord1 = new List<int>();
        public static List<int> bord2 = new List<int>();
        public static List<Person> CreatingGroups()
        {
            string[] names = Person.GetNames();
            List<Person> Guests = Person.CreatingGuests(names);
            Queue queueLobbyGroups = new Queue();
            Random rnd = new Random();
            string[] GUITest = new string[30];
            int nrOfGroups = 30;
            int peoplePerGroup = 0;
            int counter = 0;

            int grpSize = 1;


            //Tar in Namn, skapar grupper på en random storlek, samt ger varje person en balance
            for (int i = 0; i < nrOfGroups; i++)
            {
                int ökning = 0;
                peoplePerGroup = rnd.Next(1, 5);
                Console.WriteLine();
                Console.WriteLine("Grupp: " + i);
                for (int j = 0; j < peoplePerGroup; j++)
                {
                    if (counter < names.Length)
                    {
                        
                        Console.WriteLine(Guests[counter].Name + " " + grpSize);
                        queueLobbyGroups.Enqueue(Guests[counter]);
                        grpSize++;
                        counter++;
                    }
                    else if (counter >= Guests.Count)
                    {
                        Console.WriteLine("Slut på gäster");
                        break;
                    }
                }
                grpSize = 1;
                Console.WriteLine("------------------");

            }
            return Guests;

        }
        public static string[] CreatingGroupss()
        {
            string[] names = Person.GetNames();
            List<Person> Guestss = Person.CreatingGuests(names);
            List<Person> LobbyGroups = new List<Person>();
            Random rnd = new Random();
            int nrOfGroups = 30;
            int räknaStor = 0;
            int räknaLiten = 0;
            int peoplePerGroup = 0;
            int counter = 0;
            int grpSize = 1;
            int r = 0;
            int test = 0;
            int pergrupp = 0;
            //Tar in Namn, skapar grupper på en random storlek, samt ger varje person en balance
            for (int i = 0; i < nrOfGroups; i++)
            {
                peoplePerGroup = rnd.Next(1, 5);
                Console.WriteLine();
                Console.WriteLine("Grupp: " + i);
                for (int j = 0; j < peoplePerGroup; j++)
                {
                    pergrupp = peoplePerGroup;
                    if (counter < names.Length)
                    {
                        if (j == 0)
                        {
                            gruppledare[r] = names[counter];
                            r++;
                        }
                        if (peoplePerGroup <= 2)
                        {
                            allanamnLiten[räknaLiten] += names[counter] + " ";
                            if (j == peoplePerGroup-1)
                            {
                                räknaLiten++;
                            }
                        }
                        if (peoplePerGroup >= 3)
                        {
                            allanamnStora[räknaStor] += names[counter] + " ";
                            if (j == peoplePerGroup-1)
                            {
                                räknaStor++;
                              
                            }
                          
                        }
                        allanamn[i] += names[counter] + " ";
                        grpSize++;
                        counter++;
                    }
                    else if (counter >= names.Length)
                    {
                        Console.WriteLine("Slut på gäster");
                        break;
                    }
                }
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
            foreach (object q in allanamnStora)
            {
                queueStora.Enqueue(q);
            }
            foreach (object q in allanamnLiten)
            {
                queueLiten.Enqueue(q);
            }
            return names;
        }

    }
}