using System;
using System.Collections.Generic;
using System.IO;

namespace тортики
{
    class Program
    {
        private static int itogCost = 0;
        private static string itogName = "";

        static void Main()
        {
            int position = 1;
            zakaz zakaz = new zakaz();
            zakaz.menu();
            Console.SetCursorPosition(0, 10);
            Console.WriteLine("Итого - " + itogCost);
            Console.WriteLine("Ваш выбор - " + itogName);
            //tortiki tortiki = new tortiki();
            Console.SetCursorPosition(0, 0);
            ConsoleKeyInfo key = Console.ReadKey();
            while (key.Key != ConsoleKey.Enter)
            {
                if (key.Key == ConsoleKey.UpArrow) { position--; }
                else if (key.Key == ConsoleKey.DownArrow) { position++; }
                else if (key.Key == ConsoleKey.Escape)
                {
                    Console.Clear();
                    zakaz.vivodName = itogName;
                    zakaz.vivodCost = itogCost;
                    zakaz.fail();
                    itogCost = 0;
                    itogName = null;
                    Console.ReadKey();
                    if (key.Key == ConsoleKey.Spacebar)
                    {
                        Console.Clear();
                        Main();
                    }
                }
                Console.Clear();
                zakaz.menu();
                Console.SetCursorPosition(0, 10);
                Console.WriteLine(itogCost);
                Console.WriteLine(itogName);
                Console.SetCursorPosition(0, position);
                Console.WriteLine("->");
                
                key = Console.ReadKey();
            }
            SrtelochkiPodMenu(position);
        }

        static void SrtelochkiPodMenu(int position)
        {
            zakaz zakaz = new zakaz();  
            ConsoleKeyInfo key;
            List<tortiki> tort = zakaz.podmenu();
            zakaz.PodmenuOutput(tort[position]);
            int positionPodMenu = 1;
            key = Console.ReadKey();
            while (key.Key != ConsoleKey.Enter)
            {
                if (key.Key == ConsoleKey.UpArrow) { positionPodMenu--; }
                else if (key.Key == ConsoleKey.DownArrow) { positionPodMenu++; }
                else if (key.Key == ConsoleKey.Escape) { Main(); }
                Console.Clear();
                zakaz.PodmenuOutput(tort[position]);
                Console.SetCursorPosition(0, positionPodMenu);
                Console.WriteLine("->");
                key = Console.ReadKey();
            }
            Console.Clear();
            if (key.Key == ConsoleKey.Enter)
            {
                itogCost += tort[position].cost[positionPodMenu];
                itogName += tort[position].name[positionPodMenu];
                
            }
            Console.Clear();
            Main();
        }
    }
}