﻿using GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Collections;
using System.Globalization;
using System.Reflection.Metadata;

namespace Resturangen_Kod
{
    internal class RunProgram
    {
        public static int increase = 0;
        public static void StartProgram()
        {
            int nedrerad = 0;
            Queue queue = new Queue();
            Queue queueStora = new Queue();
            Queue queueLiten = new Queue();
            int start = 0;
            string[] Empty = { "Empty", "Empty", "Empty", "Empty" };
            int ökning = 0;
            string[] waiter = { "Elias", "Emma", "Kenneth", };
            Restaurant.CreatingGroupss();

            foreach (object q in Restaurant.allanamn)
            {
                queue.Enqueue(q);
            }
            while (true)
            {
                Console.Clear();
                Kitchen.kitchen();
                Console.WriteLine(waiter[2]);
                for (int Bord = 0; Bord < 5; Bord++)
                {
                    if (ökning < Restaurant.bord1.Count && start > 0)
                    {
                        bigtables.BigTables(waiter, Restaurant.gruppledare[Restaurant.bord1[ökning]], Restaurant.ints1[Restaurant.bord1[ökning]]);
                        if (Bord == 0)
                        {
                            Console.Write(waiter[0]);
                        }
                        Restaurant.queueStora.Dequeue();
                        queue.Dequeue();


                    }
                    else if (ökning >= Restaurant.bord1.Count || start == 0)
                    {
                        bigtables.BigTables(waiter, Restaurant.gruppledare[ökning], 2);
                    }
                    if (ökning < Restaurant.bord2.Count && start > 0)
                    {
                        smallTables.SmallTables(waiter, Restaurant.gruppledare[Restaurant.bord2[ökning]], Restaurant.ints1[Restaurant.bord2[ökning]]);
                        Restaurant.queueLiten.Dequeue();
                        if (Bord == 0)
                        {
                            Console.Write(waiter[1]);
                        }
                        queue.Dequeue();
                    }
                    else if (ökning >= Restaurant.bord2.Count || start == 0)
                    {
                        smallTables.SmallTables(waiter, Restaurant.gruppledare[ökning], 3);
                    }
                    if (start > 0)
                    {
                        if (ökning >= 29)
                        {
                            ökning = 29;
                        }
                        else
                        {
                            ökning++;
                        }
                    }
                }
                start++;
                Entre.entre();
                Console.SetCursorPosition(58, 68);// postion för waiter
                if (queue.Count == 0) 
                {
                    Console.WriteLine(""); // waiter2 försvinner när det är noll i den allmänna queue
                }
                else
                {
                    Console.WriteLine(waiter[2]);
                }
                Console.WriteLine();
                foreach (object qStora in Restaurant.queueStora)
                {
                    Console.WriteLine(qStora);
                }
                
                foreach (object qLiten in Restaurant.queueLiten)
                {
                    Console.SetCursorPosition(75, 70 - nedrerad);
                    Console.WriteLine(qLiten);
                    nedrerad--;
                }
                nedrerad = 0;
                //foreach (object qDone in queue) stora listan
                //{
                //    Console.WriteLine(qDone);
                //}
                Console.ReadKey();
            }
        }
        }
}
