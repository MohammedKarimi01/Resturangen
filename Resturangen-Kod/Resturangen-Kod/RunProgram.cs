using GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Collections;
namespace Resturangen_Kod
{
    internal class RunProgram
    {
        public static int increase = 0;
        public static void StartProgram()
        {
            Queue queue = new Queue();
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
                for (int k = 0; k < 5; k++)
                {
                    if (ökning < Restaurant.bord1.Count && start > 0)
                    {
                        bigtables.BigTables(waiter, Restaurant.gruppledare[Restaurant.bord1[ökning]], Restaurant.ints1[Restaurant.bord1[ökning]]);
                        Console.WriteLine(waiter[0]);
                        queue.Dequeue();
                        

                    }
                    else if (ökning >= Restaurant.bord1.Count || start == 0)
                    {
                        bigtables.BigTables(waiter, Restaurant.gruppledare[ökning], 2);
                        Console.WriteLine(waiter[0]);
                    }

                    if (ökning < Restaurant.bord2.Count && start > 0)
                    {
                        smallTables.SmallTables(waiter, Restaurant.gruppledare[Restaurant.bord2[ökning]], Restaurant.ints1[Restaurant.bord2[ökning]]);
                        Console.WriteLine(waiter[1]);
                        queue.Dequeue();
                    }
                    else if (ökning >= Restaurant.bord2.Count || start == 0)
                    {
                        smallTables.SmallTables(waiter, Restaurant.gruppledare[ökning], 3);
                        Console.WriteLine(waiter[1]);
                    }
                    if (start > 0)
                    {
                        ökning++;
                    }
                }
                start++;
                Entre.entre();
                foreach (object qDone in queue)
                {
                    Console.WriteLine(qDone);
             //       Console.WriteLine(queue.Dequeue() + " blir insläppt");
                }

                Console.ReadKey();
            }
        }
        }
}
