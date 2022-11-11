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
    internal class BigTable
    {
        public static void BigTables(string[] waiter, string booked, int grupp)
        {
            string[] guests = { "+1", "+2", "+3", "Empty" };
            Random rnd = new Random();
            int sidolängd = 0;
            string FrameTop = "-";
            string[,] drawArray = new string[50, 5];
            string FrameSide = "|";
            Console.WriteLine();
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
    internal class SmallTables
    {
        public static void SmallTable(string[] waiter, string booked, int grupp)
        {
            string[] guests = { "+1", "+2", "+3", "Empty" };
            Random rnd = new Random();
            int sidolängd2 = 0;
            string FrameTop = "-";
            string[,] drawArray2 = new string[30, 2];
            string FrameSide = "|";
            Console.SetCursorPosition((Console.WindowWidth + 39) / 2, Console.CursorTop);
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
        public static void EntreMethod()
        {
            string FrameSide = "|";
            string FrameTop = "-";
            string entre = "Entre";
            Console.WriteLine();
            for (int i = 0; i < 3; i++)
            {
                Console.SetCursorPosition((Console.WindowWidth - entre.Length + 2) / 2, Console.CursorTop);
            }

            Console.WriteLine();
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
