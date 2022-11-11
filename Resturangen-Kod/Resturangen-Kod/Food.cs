using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resturangen_Kod
{
    public class Food
    {
        //Alla properties för food
        public string FoodName { get; set; }
        public int FoodPrice { get; set; }
        public bool Cooked { get; set; }
        public int TabelDestination { get; set; }
        public int FoodQuality { get; set; }
        public static List<Food> Menu = new List<Food>();

        public Food(string foodname, int foodprice, bool cooked, int tabeldestination, int foodquality)
        {
            FoodName = foodname;
            FoodPrice = foodprice;
            Cooked = cooked;
            TabelDestination = tabeldestination;
            FoodQuality = foodquality;
        }
        // Skapar Menyn till resturangen, samt lägger in 3 rätter med olika vilkor
        public static List<Food> CreatingMenu()
        {
            List<Food> Menu = new List<Food>();
         
            Menu.Add(new Food("Fisk", 95, false, 0, 0));
            Menu.Add(new Food("Kött", 149, false, 0, 0));
            Menu.Add(new Food("Vegitariskt", 129, false, 0, 0));

            return Menu;
        }
    }
}
