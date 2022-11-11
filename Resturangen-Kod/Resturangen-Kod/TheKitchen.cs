using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resturangen_Kod
{

    public class TheKitchen 
    {
        
        
        public TheKitchen()
        {
            
        }
        public static string[] TakeOrderToKitchen(string orderdFood)
        {
           //Gå till bord med gäster, ta order, och flytta order till köket.
            


            return null;
        }
        public static List<Food> CookFood(List<Food> orderdFood)
        {   //Ta in maten, Ge den till en random chef, tillaga den på 3Tid, Cooked på true, returnera maten.
            //Ta in maten från waiters > Laga den på 3 sek ish, lägg tillbaka den på disken och ropa på ledig servitör
            Food food = new Food(" ", 0, false, 0, 0);
            Chefs.CreatingChefs();
            Queue FoodQueue = new Queue();
            FoodQueue.Enqueue(orderdFood);

        
            if(food.Cooked == false)
            {
                Console.WriteLine("Maten tillagas.");
                //Thread.Sleep(3000);
                food.Cooked = true;
            }
            else if(food.Cooked == true)
            {
                Console.WriteLine("{orderdFood} har tillagats och är redo för att serveras", FoodQueue.Dequeue());
            }

            return orderdFood;
        }
        public static string[] TakeFoodFromKitchen()
        {
            //Gå till köket > Hämta färdig mat > lämmna mat på rätt bord.


            return null;
        }
    }

}
