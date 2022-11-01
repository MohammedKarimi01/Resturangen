using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Resturangen_Kod
{
    internal class RunProgram
    {

        public static void StartProgram()
        {
            string[] waiter = { "waiter1", "waiter2", "waiter3" };
            string[] namn3 = { "test1", "test2", "test3", "test4", "test5", "test6", "test7", "test8", "test9", "test10" };
            Tabels TableEmpty = new Tabels();
            Tabels TableFilled = new Filled();
           // TableEmpty.Draw(waiter, namn3);
            //Console.WriteLine();
            Kitchen.kitchen();
            for (int i = 0; i < 5; i++)
            {
                bigtables.BigTables(waiter, namn3);
                smallTables.SmallTables(waiter, namn3);
            }

            Entre.entre();

            //TableFilled.Draw(waiter, namn3);
            
            //Persons.CreatingPersons();
            //Chefs.CreatingChefs();
            //Waiters.CreatingWaiter();
        }
    }
}
