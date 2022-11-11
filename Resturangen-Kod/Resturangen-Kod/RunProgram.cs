using GUI;
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
            string[] Händelser = new string[5];
            int nedrerad = 0;
            Queue queue = new Queue();
            Queue queueStora = new Queue();
            Queue queueLiten = new Queue();
            int start = 0;
            int ökning = 0;
            string[] waiter = { "Elias", "Emma", "Kenneth", };
            Restaurant.CreatingGroupss();
            int[] stortBord = new int[] {0, 0, 0, 0, 0};
            int[] småBord = new int[] { 0, 0, 0, 0, 0};
            bool[] waiterWasThere = new bool[5];
            bool[] waiterWasThereBord2 = new bool[5];
            int tester = 0;
            int VartWaiterStår = -1;
            int VartWaiterStår2 = -1;
            int[] ökningBord = new int[] { 0, 1, 2, 3, 4 };
            int[] ökningBord2 = new int[] { 0, 1, 2, 3, 4 };
            int[] NästaServering = new int[] { 0, 0, 0, 0, 0 };
            int[] NästaServering2 = new int[] { 0, 0, 0, 0, 0 };
            int taNyBeställning = -1;
            int taNyBeställning2 = -1;
            bool waiter2Used = false;
            bool waiter1Used = false;
            bool waiter1Stuck = false;
            bool iKöket = true;
            string Stängd = "Restaurangen är stängd!";
            foreach (object q in Restaurant.allanamn)
            {
                queue.Enqueue(q);
            }
            while (true)
            {
                waiter1Used = false;
                waiter2Used = false;
                VartWaiterStår2 = -1;
                VartWaiterStår = -1; // försöker visa vart waiter ska vara
                Console.Clear();
                Kitchen.kitchen();
                if (taNyBeställning == -2)
                {
                    Console.WriteLine(waiter[0]); // visar att elias är vid kitchen
                    taNyBeställning = -1;
                    iKöket = true;
                }
                else
                {
                    taNyBeställning = tester;
                }
                Console.WriteLine();
                if (waiter1Used == false)
                {
                    if (taNyBeställning2 == -2 && waiter1Stuck == false)
                    {
                        Console.SetCursorPosition(Console.WindowWidth / 2 - 8, 1);
                        Console.WriteLine(waiter[1]); // visar att Emma är vid kitchen
                        taNyBeställning2 = -1;
                        iKöket = true;
                    }
                    else
                    {
                        taNyBeställning2 = tester;
                    }
                }
                 else if (waiter1Stuck == true)
                {
                    if (taNyBeställning2 == -2 && waiter1Used == false)
                    {
                        taNyBeställning2 = -1;
                        iKöket = true;
                    }
                    else
                    {
                        taNyBeställning2 = tester;
                    }
                }

                Console.WriteLine(start);
                for (int Bord = 0; Bord < 5; Bord++)
                {
                    if (ökningBord[Bord] > Restaurant.bord1.Count && ökningBord2[Bord] > Restaurant.bord2.Count)
                    {
                        Händelser[3] = Stängd;
                    }
                    if (waiterWasThere[Bord] == false && Bord == 0 && NästaServering[Bord] == 0 && ökningBord[Bord] < Restaurant.bord1.Count) // första bordet
                    {
                        Restaurant.queueStora.Dequeue();

                        Console.WriteLine(waiter[0]);
                        VartWaiterStår = Bord;
                        waiterWasThere[Bord] = true;
                        taNyBeställning = -2;
                    }
                    else if (waiterWasThere[Bord] == false && start > 0 && VartWaiterStår == -1 && taNyBeställning == tester && NästaServering[Bord] == 0 && ökningBord[Bord] < Restaurant.bord1.Count) // alla andra bord
                    {
                        taNyBeställning = -2;
                        BigTable.BigTables(waiter, Restaurant.gruppledare[Restaurant.bord1[ökning]], Restaurant.ints1[Restaurant.bord1[ökning]]);
                        if (Bord == 0)
                        {
                            Console.Write(waiter[0]);
                            FoodProcess.GuestOrder(0);
                        }
                        Restaurant.queueStora.Dequeue();
                        Console.SetCursorPosition(Console.WindowWidth - 120, Console.CursorTop);
                        Console.WriteLine(waiter[0]);
                        waiterWasThere[Bord] = true;
                        VartWaiterStår = Bord;

                    }
                    if (waiterWasThere[Bord] == true)
                    {
                        stortBord[Bord]++;

                        if (stortBord[Bord] >= 10)
                        {
                            stortBord[Bord] = 0;
                            waiterWasThere[Bord] = false;
                            NästaServering[Bord] = 1;
                            ökningBord[Bord] += 5;
                            taNyBeställning = Bord;

                        }
                    }
                    if (ökningBord[Bord] < Restaurant.bord1.Count && waiterWasThere[Bord] == true) // väljer ut bord 0
                    {
                        bigtables.BigTables(waiter, Restaurant.gruppledare[Restaurant.bord1[ökningBord[Bord]]], Restaurant.ints1[Restaurant.bord1[ökningBord[Bord]]]);
                    }
                    else if (NästaServering[Bord] == 1)
                    {
                        if (Bord >= 1)
                        {
                            Console.SetCursorPosition(Console.WindowWidth / Console.WindowWidth - 1, Console.CursorTop);
                            Console.WriteLine(waiter[2]);
                            bigtables.BigTables(waiter, Restaurant.gruppledare[ökning], 2);
                            waiter2Used = true;
                        }
                        else
                        {
                            waiter2Used = true;
                            Console.WriteLine(waiter[2]);
                            bigtables.BigTables(waiter, Restaurant.gruppledare[ökning], 2);
                        }
                        NästaServering[Bord] = 0;
                    }
                    else if (ökningBord[Bord] >= Restaurant.bord1.Count)
                    {
                        bigtables.BigTables(waiter, Restaurant.gruppledare[ökning], 2); // empty
                    }
                    else
                    {
                        bigtables.BigTables(waiter, Restaurant.gruppledare[ökning], 2); // empty
                    }
                    if (waiterWasThereBord2[Bord] == false && Bord == 0 && NästaServering2[Bord] == 0 && ökningBord2[Bord] < Restaurant.bord2.Count)
                    }
                    else if (ökning >= Restaurant.bord1.Count || start == 0)
                    {
                        BigTable.BigTables(waiter, Restaurant.gruppledare[ökning], 2);
                    }
                    if (ökning < Restaurant.bord2.Count && start > 0)
                    {
                        Restaurant.queueLiten.Dequeue();
                        Console.SetCursorPosition(Console.WindowWidth - 40, Console.CursorTop);
                        Console.WriteLine(waiter[1]);
                        VartWaiterStår2 = Bord;
                        waiterWasThereBord2[Bord] = true;
                        taNyBeställning2 = -2;
                    }
                    else if (waiterWasThereBord2[Bord] == false && VartWaiterStår2 == -1 && taNyBeställning2 == tester && NästaServering2[Bord] == 0 && ökningBord2[Bord] < Restaurant.bord2.Count)
                    {
                        taNyBeställning2 = -2;
                        Restaurant.queueLiten.Dequeue();
                        Console.SetCursorPosition(Console.WindowWidth - 40, Console.CursorTop);
                        Console.WriteLine(waiter[1]);
                        waiterWasThereBord2[Bord] = true;
                        VartWaiterStår2 = Bord;
                    }
                    if (waiterWasThereBord2[Bord] == true)
                    {
                        småBord[Bord]++;

                        if (småBord[Bord] >= 10)
                        {
                            småBord[Bord] = 0;
                            waiterWasThereBord2[Bord] = false;
                            NästaServering2[Bord] = 1;
                            ökningBord2[Bord] += 5;
                            taNyBeställning2 = Bord;

                        }
                    }
                    if (ökningBord2[Bord] < Restaurant.bord2.Count && waiterWasThereBord2[Bord] == true) // väljer ut bord 0
                    {
                        smallTables.SmallTables(waiter, Restaurant.gruppledare[Restaurant.bord2[ökningBord2[Bord]]], Restaurant.ints1[Restaurant.bord2[ökningBord2[Bord]]]);
                        if (Bord == 0)
                        {
                            Console.Write(waiter[1]);

                        }
                        queue.Dequeue();
                    }
                    else if (NästaServering2[Bord] == 1)
                    {
                        if (Bord == 1)
                        {
                            Console.SetCursorPosition(Console.WindowWidth - 10, Console.CursorTop);
                            smallTables.SmallTables(waiter, Restaurant.gruppledare[ökning], 4);
                            waiter1Used = true;
                        }
                        else
                        {
                            Console.SetCursorPosition(Console.WindowWidth - 10, Console.CursorTop);
                            waiter1Used = true;
                            smallTables.SmallTables(waiter, Restaurant.gruppledare[ökning], 4);
                        }
                        NästaServering2[Bord] = 0;
                    }
                    else if (ökningBord2[Bord] >= Restaurant.bord2.Count)
                    {
                        smallTables.SmallTables(waiter, Restaurant.gruppledare[ökning], 4); // empty
                    }
                    else
                    {
                        smallTables.SmallTables(waiter, Restaurant.gruppledare[ökning], 4);
                    }
                    if (taNyBeställning2 == -1)
                    {
                        taNyBeställning2 = tester;
                        tester++;
                        if (tester > 4)
                        {
                            tester = 0;
                    else if (ökning >= Restaurant.bord2.Count || start == 0)
                    {
                        SmallTables.SmallTable(waiter, Restaurant.gruppledare[ökning], 3);
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

                Entre.entre();
                Console.SetCursorPosition(Console.WindowWidth / 2 - 2, Console.CursorTop - 3);// postion för waiter
                if (queue.Count == 0)
                Entre.EntreMethod();
                Console.SetCursorPosition(Console.WindowWidth / 2 -2, Console.CursorTop-3);// postion för waiter
                if (queue.Count == 0) 
                {
                    Console.WriteLine(""); // waiter2 försvinner när det är noll i den allmänna queue
                }
                else
                {
                    if (waiter2Used == true)
                    Console.WriteLine(waiter[2]);     

                    if (start == 0)
                    {
                        Console.WriteLine();
                    }
                    else if (waiter2Used == false)
                    {
                        Console.WriteLine(waiter[2]);
                    }
                }
                
                //for (int i = 0; i < 3; i++)
                //{
                //    Console.WriteLine();
                //}
                foreach (object qStora in Restaurant.queueStora)
                {
                    Console.WriteLine(qStora);
                }
                foreach (object qLiten in Restaurant.queueLiten)
                {
                    if (iKöket == true)
                    {
                        Console.SetCursorPosition(75, 70-nedrerad);
                        Console.WriteLine(qLiten);
                        nedrerad--;
                    }
                    else
                    {
                        Console.SetCursorPosition(75, 72-nedrerad);
                        Console.WriteLine(qLiten);
                        nedrerad--;
                    }
                }
                if (start == 0)
                {
                    Händelser[0] = "Kenneth tar emot gäster, Elias och Emma har tagit emot sina första gäster";
                }
                if (start == 1)
                {
                    Händelser[1] = "Kenneth välkommnar gästerna längst fram i kön. Elias och Emma lämnar beställningen till köket";
                }
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine(Händelser[i]);
                }
                if (waiter1Used == true)
                {
                    waiter1Stuck = true;
                }
                if (waiter1Used == false)
                {
                    waiter1Stuck = false;
                }
                start++;
                nedrerad = 0;
                iKöket = false;
                Console.WriteLine(start);
                //foreach (object qDone in queue) stora listan
                //{
                //    Console.WriteLine(qDone);
                //}
                    Console.SetCursorPosition(75, 70 - nedrerad);
                    Console.WriteLine(qLiten);
                    nedrerad--;
                }
                nedrerad = -2;
                Console.ReadKey();
            }
            }
        }
        
}
