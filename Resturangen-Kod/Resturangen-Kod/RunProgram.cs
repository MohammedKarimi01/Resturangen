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
        public static int increase = 0;
        public static void StartProgram()
        {
            string[] Empty = { "Empty", "Empty", "Empty", "Empty" };
            int ökning = 0;
            string[] waiter = { "Elias", "Emma", "Kenneth", };
            Restaurant.CreatingGroupss();
            while (true)
            {
                Kitchen.kitchen();
                for (int k = 0; k < 5; k++)
                {
                    if (ökning < Restaurant.bord1.Count)
                    {
                        bigtables.BigTables(waiter, Restaurant.gruppledare[Restaurant.bord1[ökning]], Restaurant.ints1[Restaurant.bord1[ökning]]);
                    }
                    else if (ökning >= Restaurant.bord1.Count)
                    {
                        bigtables.BigTables(waiter, Restaurant.gruppledare[ökning], 2);
                    }

        public static void StartProgram()
        {
              Restaurant.CreatingGroups();
            //Persons.CreatingPersons();
            //Chefs.CreatingChefs();
            //Waiters.CreatingWaiter();
        }
    }
}
