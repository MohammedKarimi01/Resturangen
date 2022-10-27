using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resturangen_Kod
{
    internal class Tabels
    {
        public int Tables { get; set; }
        public int TableSize { get; set; }
        public static void Draw()
        {
            int sidolängd2 = 0;
            string[,] drawArray = new string[50, 5];
            string[,] drawArray2 = new string[30, 2];
            string guests = "Empty";
            string guesttable2 = "Not Booked";
            string guest2 = "E0";
            int sidolängd = 0;
            string name = "Not Booked";
            string FrameSide = "|";
            string FrameTop = "-";
            string kitchen = "Kitchen";
            Console.SetCursorPosition((Console.WindowWidth - kitchen.Length) / 2, Console.CursorTop);
            Console.WriteLine("| " + kitchen + " |");
            Console.SetCursorPosition((Console.WindowWidth - FrameTop.Length - 6) / 2, Console.CursorTop);
            for (int i = 0; i < kitchen.Length + 4; i++) // printar kitchen koden högst upp
            {
                Console.Write(FrameTop);
            }
            Console.WriteLine();
            for (int k = 0; k < 5; k++)
            {
                sidolängd = 0;
                sidolängd2 = 0;

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


                //Console.SetCursorPosition(79, 3);
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

        }
    }
}
