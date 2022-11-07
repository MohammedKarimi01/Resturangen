using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace Resturangen_Kod
{
    internal class Tabels
    {
        public int Tables { get; set; }
        public int TableSize { get; set; }
        public virtual void Draw()
        {

        }
        public virtual void Draw(string[] waitertest, string[] booked)
        {
            //string[] waiter = { "Waiter1", "Waiter2", "Waiter3" }; // ba ett test
            string entre = "Entre";
            int sidolängd2 = 0;
            string[,] drawArray = new string[50, 5];
            string[,] drawArray2 = new string[30, 2];
            string guests = "Empty";
            string guesttable2 = "Not Booked";
            //string[] guest2 = { "E1", "E2", "E3", "E4"};
            int sidolängd = 0;
            string name = "Not Booked";
            string FrameSide = "|";
            string FrameTop = "-";
            string kitchen = "Kitchen";

            Console.SetCursorPosition((Console.WindowWidth - kitchen.Length) / 2, Console.CursorTop);
            Console.WriteLine("| " + kitchen + " |");
            Console.SetCursorPosition((Console.WindowWidth - kitchen.Length) / 2, Console.CursorTop);
            for (int i = 0; i < kitchen.Length + 4; i++) // printar kitchen koden högst upp
            {
                Console.Write(FrameTop);
            }
            Console.WriteLine();
            for (int i = 0; i < 3; i++)
            {
                Console.SetCursorPosition((Console.WindowWidth - kitchen.Length + 3) / 2, Console.CursorTop);
               // Console.WriteLine(waiter[i]);
            }
            Console.WriteLine();
            for (int Tables = 0; Tables < 5; Tables++) // k = borden
            {
                sidolängd = 0;
                sidolängd2 = 0;

                Console.WriteLine();
                //Console.WriteLine(waiter[0]); // if k = 0 då äre bord 1 osv detta är för vänster sida

                for (int i = 0; i < drawArray.GetLength(0); i++) // överesidan på bordet
                {
                    sidolängd++; // behövs för att veta slutet av bordet
                    Console.Write("-");
                }
                int newsidolängd = Console.WindowWidth - sidolängd; // räknar ut hur långt bordet är
                Console.WriteLine();
                for (int j = 0; j < drawArray.GetLength(1); j++)
                {
                    Console.Write("|"); // vänstra sidan av bordet
                    Console.SetCursorPosition((Console.WindowWidth - FrameSide.Length) - newsidolängd, Console.CursorTop); // räknar ut vart den ska placera den sista |
                    Console.WriteLine(FrameSide); // högra sidan av bordet kan lika gärna stå -
                    if (j == 0)
                    {
                        Console.Write("| " + name); // skriver ut namnet av gästen (den som bokar)
                        Console.SetCursorPosition((Console.WindowWidth - FrameSide.Length) - newsidolängd - guests.Length, Console.CursorTop);
                        Console.Write(guests); // det första sällskapet till den bokade gästen
                        Console.SetCursorPosition((Console.WindowWidth - FrameSide.Length) - newsidolängd, Console.CursorTop);
                        Console.WriteLine(FrameSide); // lägger ut den sista |
                    }
                    if (j == 3)
                    {
                        Console.Write("| " + guests);
                        Console.SetCursorPosition((Console.WindowWidth - FrameSide.Length) - newsidolängd - guests.Length, Console.CursorTop);
                        Console.Write(guests);
                        Console.SetCursorPosition((Console.WindowWidth - FrameSide.Length) - newsidolängd, Console.CursorTop);
                        Console.WriteLine(FrameSide);
                    }
                }

                for (int i = 0; i < drawArray.GetLength(0); i++)
                {
                    Console.Write("-");
                }
                Console.SetCursorPosition((Console.WindowWidth + 39) / 2, Console.CursorTop);
                //if (Tables == 1) // lägg till if tables == 1 && notempty == true, skriv där nere
                //{
                //    Console.WriteLine(waiter[1]); // detta är för höger sida

                //}
         //       Console.WriteLine(waiter[1]); // detta är för höger sida
                Console.SetCursorPosition((Console.WindowWidth + 39) / 2, Console.CursorTop);
                for (int f = 0; f < drawArray2.GetLength(0); f++) // andra bordet
                {
                    sidolängd2++;
                    Console.Write("-");
                }
                int newsidolängd2 = (Console.WindowWidth + 39) / 2 - sidolängd2; // räknar ut hur långt det andra bordet är
                Console.WriteLine();
                for (int o = 0; o < drawArray2.GetLength(1); o++)
                {
                    Console.SetCursorPosition((Console.WindowWidth + 39) / 2, Console.CursorTop);
                    Console.Write("|");
                    Console.SetCursorPosition((Console.WindowWidth + 37) - newsidolängd2, Console.CursorTop); // räknar ut vart den ska placera den sista |
                    Console.WriteLine(FrameSide); // högra sidan av bordet kan lika gärna stå -
                    if (o == 0)
                    {
                        Console.SetCursorPosition((Console.WindowWidth + 39) / 2, Console.CursorTop);

                        Console.Write("| " + guesttable2);
                        Console.SetCursorPosition((Console.WindowWidth + 37) - newsidolängd2 - guests.Length, Console.CursorTop);
                        Console.Write(guests);
                        Console.SetCursorPosition((Console.WindowWidth + 37) - newsidolängd2, Console.CursorTop); // räknar ut vart den ska placera den sista |
                        Console.WriteLine(FrameSide); // andra bordets högra sida
                    }
                }

                Console.SetCursorPosition((Console.WindowWidth + 39) / 2, Console.CursorTop);
                for (int i = 0; i < drawArray2.GetLength(0); i++)
                {

                    Console.Write("-");
                }
            }
            Console.WriteLine();
            for (int i = 0; i < 3; i++)
            {
                Console.SetCursorPosition((Console.WindowWidth - entre.Length + 2) / 2, Console.CursorTop);
         //       Console.WriteLine(waiter[i]);
            }
            Console.WriteLine();
            //           Console.SetCursorPosition(0, 81);
            Console.SetCursorPosition((Console.WindowWidth - entre.Length) / 2, Console.CursorTop);
            for (int i = 0; i < entre.Length + 4; i++) // printar kitchen koden högst upp
            {
                Console.Write(FrameTop);
            }
            Console.WriteLine();
            Console.SetCursorPosition((Console.WindowWidth - entre.Length) / 2, Console.CursorTop);
            Console.WriteLine("| " + entre + " |");

        }
    }
    internal class Kitchen
    {
        public static void kitchen()
        {
            string FrameTop = "-";
            string kitchen = "Kitchen";
            Console.SetCursorPosition((Console.WindowWidth - kitchen.Length) / 2, Console.CursorTop);
            Console.WriteLine("| " + kitchen + " |");
            Console.SetCursorPosition((Console.WindowWidth - kitchen.Length) / 2, Console.CursorTop);
            for (int i = 0; i < kitchen.Length + 4; i++) // printar kitchen koden högst upp
            {
                Console.Write(FrameTop);
            }
        }
    }
    internal class bigtables
    {
        public static void BigTables(string[] waiter, string booked, int grupp)
        {
            string[] guests = { "+1", "+2", "+3", "Empty" };
            Random rnd = new Random();
           // int nameRandom = rnd.Next(0, 10);
           // int c = rnd.Next(0, 3);
            int sidolängd = 0;
            string FrameTop = "-";
            string[,] drawArray = new string[50, 5];
            string FrameSide = "|";
            Console.WriteLine();
            //Console.WriteLine(waiter[0]);
            for (int i = 0; i < drawArray.GetLength(0); i++) // överesidan på bordet
            {
                sidolängd++; // behövs för att veta slutet av bordet
                Console.Write("-");
            }
            int newsidolängd = Console.WindowWidth - sidolängd; // räknar ut hur långt bordet är
            Console.WriteLine();
            for (int j = 0; j < drawArray.GetLength(1); j++)
            {
                Console.Write("|"); // vänstra sidan av bordet
                Console.SetCursorPosition((Console.WindowWidth - FrameSide.Length) - newsidolängd, Console.CursorTop); // räknar ut vart den ska placera den sista |
                Console.WriteLine(FrameSide); // högra sidan av bordet kan lika gärna stå -
                if (j == 0)
                {
                    // skriver ut namnet av gästen (den som bokar)
                    if (grupp >= 3)
                    {
                        Console.Write("| " + booked);
                        Console.SetCursorPosition((Console.WindowWidth - FrameSide.Length) - newsidolängd - guests[0].Length, Console.CursorTop);

                        Console.Write(guests[0]);
                    }
                    else
                    {
                        Console.Write("| " + guests[3]);
                        Console.SetCursorPosition((Console.WindowWidth - FrameSide.Length) - newsidolängd - guests[3].Length, Console.CursorTop);
                        Console.Write(guests[3]);
                    }
                    // det första sällskapet till den bokade gästen
                    Console.SetCursorPosition((Console.WindowWidth - FrameSide.Length) - newsidolängd, Console.CursorTop);
                    Console.WriteLine(FrameSide); // lägger ut den sista |
                }
                if (j == 3)
                {
                    Console.Write("| ");
                    if (grupp >= 3)
                    {
                        Console.Write(guests[1]);
                    }
                    else
                    {
                        Console.Write(guests[3]);
                    }

                    // Console.Write("| " + guests[c]);
                    Console.SetCursorPosition((Console.WindowWidth - FrameSide.Length) - newsidolängd - guests[1].Length, Console.CursorTop);
                    if (grupp >= 4)
                    {

                        Console.Write(guests[2]);
                    }
                    else
                    {
                        Console.SetCursorPosition((Console.WindowWidth - FrameSide.Length) - newsidolängd - guests[3].Length, Console.CursorTop);
                        Console.Write(guests[3]);
                    }
                    Console.SetCursorPosition((Console.WindowWidth - FrameSide.Length) - newsidolängd, Console.CursorTop);
                    Console.WriteLine(FrameSide);
                }
            }

            for (int i = 0; i < drawArray.GetLength(0); i++)
            {
                Console.Write("-");
            }
        }
    }
    internal class smallTables
    {
        public static void SmallTables(string[] waiter, string booked, int grupp)
        {
            string[] guests = { "+1", "+2", "+3", "Empty" };
            Random rnd = new Random();
           // int nameRandom = rnd.Next(0, 10);
            int sidolängd2 = 0;
            string FrameTop = "-";
            string[,] drawArray2 = new string[30, 2];
            string FrameSide = "|";
            Console.SetCursorPosition((Console.WindowWidth + 39) / 2, Console.CursorTop);
     //       Console.WriteLine(waiter[1]); // detta är för höger sida
            Console.SetCursorPosition((Console.WindowWidth + 39) / 2, Console.CursorTop);
            for (int f = 0; f < drawArray2.GetLength(0); f++) // andra bordet
            {
                sidolängd2++;
                Console.Write("-");
            }
            int newsidolängd2 = (Console.WindowWidth + 39) / 2 - sidolängd2; // räknar ut hur långt det andra bordet är
            Console.WriteLine();
            for (int o = 0; o < drawArray2.GetLength(1); o++)
            {
                Console.SetCursorPosition((Console.WindowWidth + 39) / 2, Console.CursorTop);
                Console.Write("|");
                Console.SetCursorPosition((Console.WindowWidth + 37) - newsidolängd2, Console.CursorTop); // räknar ut vart den ska placera den sista |
                Console.WriteLine(FrameSide); // högra sidan av bordet kan lika gärna stå -
                if (o == 0)
                {
                    Console.SetCursorPosition((Console.WindowWidth + 39) / 2, Console.CursorTop);
                    if (grupp == 2)
                    {
                        Console.Write("| " + booked);
                        Console.SetCursorPosition((Console.WindowWidth + 37) - newsidolängd2 - guests[0].Length, Console.CursorTop);
                        Console.Write(guests[0]);
                    }
                    else if (grupp == 1)
                    {
                        Console.Write("| " + booked);
                        Console.SetCursorPosition((Console.WindowWidth + 37) - newsidolängd2 - guests[3].Length, Console.CursorTop);
                        Console.Write(guests[3]);
                    }
                    else if (grupp > 2)
                    {
                        Console.Write("| " + guests[3]);
                        Console.SetCursorPosition((Console.WindowWidth + 37) - newsidolängd2 - guests[3].Length, Console.CursorTop);
                        Console.Write(guests[3]);
                    }
                    Console.SetCursorPosition((Console.WindowWidth + 37) - newsidolängd2, Console.CursorTop); // räknar ut vart den ska placera den sista |
                    Console.WriteLine(FrameSide); // andra bordets högra sida
                }
            }

            Console.SetCursorPosition((Console.WindowWidth + 39) / 2, Console.CursorTop);
            for (int i = 0; i < drawArray2.GetLength(0); i++)
            {

                Console.Write("-");
            }
        }
    }
    internal class Entre
    {
        public static void entre()
        {
            string FrameSide = "|";
            string FrameTop = "-";
            string entre = "Entre";
            Console.WriteLine();
            for (int i = 0; i < 3; i++)
            {
                Console.SetCursorPosition((Console.WindowWidth - entre.Length + 2) / 2, Console.CursorTop);
                //Console.WriteLine(waiter[i]);
            }

            Console.WriteLine();
            //           Console.SetCursorPosition(0, 81);
            Console.SetCursorPosition((Console.WindowWidth - entre.Length) / 2, Console.CursorTop);
            for (int i = 0; i < entre.Length + 4; i++) // printar kitchen koden högst upp
            {
                Console.Write(FrameTop);
            }
            Console.WriteLine();
            Console.SetCursorPosition((Console.WindowWidth - entre.Length) / 2, Console.CursorTop);
            Console.WriteLine("| " + entre + " |");
        }
    }
    class Filled : Tabels
    {
        public override void Draw(string[] waiter, string[] booked)
        {

            string entre = "Entre";
            int sidolängd2 = 0;
            string[,] drawArray = new string[50, 5];
            string[,] drawArray2 = new string[30, 2];
            Random rnd = new Random();
            List<int> possible = Enumerable.Range(0, 10).ToList();
            List<int> listNumbers = new List<int>();
            string[] guests = { "+1", "+2", "+3", "Empty" };
            int sidolängd = 0;
            string FrameSide = "|";
            string FrameTop = "-";
            string kitchen = "Kitchen";
            Console.SetCursorPosition((Console.WindowWidth - kitchen.Length) / 2, Console.CursorTop);
            Console.WriteLine("| " + kitchen + " |");
            Console.SetCursorPosition((Console.WindowWidth - kitchen.Length) / 2, Console.CursorTop);
            for (int i = 0; i < kitchen.Length + 4; i++) // printar kitchen koden högst upp
            {
                Console.Write(FrameTop);
            }

            Console.WriteLine();
            for (int i = 0; i < 3; i++)
            {
                Console.SetCursorPosition((Console.WindowWidth - kitchen.Length + 3) / 2, Console.CursorTop);
                Console.WriteLine(waiter[i]); //waiters
            }
            Console.WriteLine();
            for (int Tables = 0; Tables < 5; Tables++) // k = borden
            {
                int nameRandom = rnd.Next(0, possible.Count);
                listNumbers.Add(possible[nameRandom]);
                possible.RemoveAt(nameRandom);
                //  int nameRandom = rnd.Next(0, 10);
                int c = rnd.Next(0, 3);
                sidolängd = 0;
                sidolängd2 = 0;

                Console.WriteLine();
                Console.WriteLine(waiter[0]); // if k = 0 då äre bord 1 osv detta är för vänster sida

                for (int i = 0; i < drawArray.GetLength(0); i++) // överesidan på bordet
                {
                    sidolängd++; // behövs för att veta slutet av bordet
                    Console.Write("-");
                }
                int newsidolängd = Console.WindowWidth - sidolängd; // räknar ut hur långt bordet är
                Console.WriteLine();
                for (int j = 0; j < drawArray.GetLength(1); j++)
                {
                    Console.Write("|"); // vänstra sidan av bordet
                    Console.SetCursorPosition((Console.WindowWidth - FrameSide.Length) - newsidolängd, Console.CursorTop); // räknar ut vart den ska placera den sista |
                    Console.WriteLine(FrameSide); // högra sidan av bordet kan lika gärna stå -
                    if (j == 0)
                    {
                        if (c >= 1)
                        {
                            Console.Write("| " + booked[nameRandom]); // skriver ut namnet av gästen (den som bokar)
                            Console.SetCursorPosition((Console.WindowWidth - FrameSide.Length) - newsidolängd - guests[c].Length, Console.CursorTop);

                            Console.Write(guests[0]);
                        }
                        else
                        {
                            Console.Write("| " + guests[3]); // skriver ut namnet av gästen (den som bokar)
                            Console.SetCursorPosition((Console.WindowWidth - FrameSide.Length) - newsidolängd - guests[3].Length, Console.CursorTop);
                            Console.Write(guests[3]);
                        }
                        // det första sällskapet till den bokade gästen
                        Console.SetCursorPosition((Console.WindowWidth - FrameSide.Length) - newsidolängd, Console.CursorTop);
                        Console.WriteLine(FrameSide); // lägger ut den sista |
                    }
                    if (j == 3)
                    {
                        Console.Write("| ");
                        if (c >= 1)
                        {
                            Console.Write(guests[1]);
                        }
                        else
                        {
                            Console.Write(guests[3]);
                        }

                        // Console.Write("| " + guests[c]);
                        Console.SetCursorPosition((Console.WindowWidth - FrameSide.Length) - newsidolängd - guests[c].Length, Console.CursorTop);
                        if (c >= 2)
                        {

                            Console.Write(guests[2]);
                        }
                        else
                        {
                            Console.SetCursorPosition((Console.WindowWidth - FrameSide.Length) - newsidolängd - guests[3].Length, Console.CursorTop);
                            Console.Write(guests[3]);
                        }
                        Console.SetCursorPosition((Console.WindowWidth - FrameSide.Length) - newsidolängd, Console.CursorTop);
                        Console.WriteLine(FrameSide);
                    }
                }

                for (int i = 0; i < drawArray.GetLength(0); i++)
                {
                    Console.Write("-");
                }
                Console.SetCursorPosition((Console.WindowWidth + 39) / 2, Console.CursorTop);
                if (Tables == 1) // lägg till if tables == 1 && notempty == true, skriv där nere
                {
                    Console.WriteLine(waiter[1]); // detta är för höger sida

                }
                Console.WriteLine(waiter[1]); // detta är för höger sida
                Console.SetCursorPosition((Console.WindowWidth + 39) / 2, Console.CursorTop);
                for (int f = 0; f < drawArray2.GetLength(0); f++) // andra bordet
                {
                    sidolängd2++;
                    Console.Write("-");
                }
                int newsidolängd2 = (Console.WindowWidth + 39) / 2 - sidolängd2; // räknar ut hur långt det andra bordet är
                Console.WriteLine();
                for (int o = 0; o < drawArray2.GetLength(1); o++)
                {
                    Console.SetCursorPosition((Console.WindowWidth + 39) / 2, Console.CursorTop);
                    Console.Write("|");
                    Console.SetCursorPosition((Console.WindowWidth + 37) - newsidolängd2, Console.CursorTop); // räknar ut vart den ska placera den sista |
                    Console.WriteLine(FrameSide); // högra sidan av bordet kan lika gärna stå -
                    if (o == 0)
                    {
                        Console.SetCursorPosition((Console.WindowWidth + 39) / 2, Console.CursorTop);

                        if (c < 1)
                        {
                            Console.Write("| " + booked[nameRandom]);
                            Console.SetCursorPosition((Console.WindowWidth + 37) - newsidolängd2 - guests[0].Length, Console.CursorTop);
                            Console.Write(guests[0]);
                        }
                        else
                        {
                            Console.Write("| " + guests[3]);
                            Console.SetCursorPosition((Console.WindowWidth + 37) - newsidolängd2 - guests[3].Length, Console.CursorTop);
                            Console.Write(guests[3]);
                        }
                        Console.SetCursorPosition((Console.WindowWidth + 37) - newsidolängd2, Console.CursorTop); // räknar ut vart den ska placera den sista |
                        Console.WriteLine(FrameSide); // andra bordets högra sida
                    }
                }

                Console.SetCursorPosition((Console.WindowWidth + 39) / 2, Console.CursorTop);
                for (int i = 0; i < drawArray2.GetLength(0); i++)
                {

                    Console.Write("-");
                }

            }

            Console.WriteLine();
            for (int i = 0; i < 3; i++)
            {
                Console.SetCursorPosition((Console.WindowWidth - entre.Length + 2) / 2, Console.CursorTop);
                Console.WriteLine(waiter[i]);
            }

            Console.WriteLine();
            //           Console.SetCursorPosition(0, 81);
            Console.SetCursorPosition((Console.WindowWidth - entre.Length) / 2, Console.CursorTop);
            for (int i = 0; i < entre.Length + 4; i++) // printar kitchen koden högst upp
            {
                Console.Write(FrameTop);
            }
            Console.WriteLine();
            Console.SetCursorPosition((Console.WindowWidth - entre.Length) / 2, Console.CursorTop);
            Console.WriteLine("| " + entre + " |");

        }
    }
}
