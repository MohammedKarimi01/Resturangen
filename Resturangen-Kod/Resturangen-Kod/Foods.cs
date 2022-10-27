using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resturangen_Kod
{
    internal class Foods
    {
        string[] FoodTypes = { "Pizza", "Hamburgare", "Kebabrulle", "Kebabtallrik" };
        int[] FoodPrices = { 100, 139, 95 };
        public string FoodType { get; set; }
        public int FoodPrice { get; set; }

        //Bara ett exempel, behövs inte vara detta.
    }
}
