using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resturangen_Kod
{
    internal class Food
    {
        string[] FoodTypes = { "Pizza", "Hamburgare", "Kebabrulle", "Kebabtallrik" };
        int[] FoodPrices = { 100, 139, 95 };
        public string FoodType { get; set; }
        public int FoodPrice { get; set; }

        //Bara ett exempel, behövs inte vara detta.
        //Fixa så att maten är objekt, så det är enklare att leka med med, då kommer rätten samt priset dirrekt.
    }
}
