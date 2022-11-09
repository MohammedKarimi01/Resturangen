using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resturangen_Kod
{
    internal class Foods
    {
        public string FoodName { get; set; }
        public int FoodPrice { get; set; }
        public bool Cooked { get; set; }
        public int TabelDestination { get; set; }
        public int FoodQuality { get; set; }
        public static List<Foods> Menu = new List<Foods>();

        public Foods(string foodname, int foodprice, bool cooked, int tabeldestination, int foodquality)
        {
            FoodName = foodname;
            FoodPrice = foodprice;
            Cooked = cooked;
            TabelDestination = tabeldestination;
            FoodQuality = foodquality;
        }
        public static List<Foods> CreatingMenu()
        {
            List<Foods> Menu = new List<Foods>();
         
            Menu.Add(new Foods("Fisk", 95, false, 0, 0));
            Menu.Add(new Foods("Kött", 149, false, 0, 0));
            Menu.Add(new Foods("Vegitariskt", 129, false, 0, 0));

            return Menu;
        }
    }
}
