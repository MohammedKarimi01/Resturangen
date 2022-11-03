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

        public static void StartProgram()
        {
            string[] waiter = { "Elias", "Emma", "Kenneth", };
            string[] names = Person.GetNames();
            //string namn = Restaurant.CreatingGroups();
            Kitchen.kitchen();
            bigtables.BigTables(waiter, names);
            smallTables.SmallTables(waiter, names);
            Entre.entre();
            Lobby.GroupCheck();
            //Restaurant.CreatingGroups();
            //Persons.CreatingPersons();
            //Chefs.CreatingChefs();
            //Waiters.CreatingWaiter();
        }
    }
}
