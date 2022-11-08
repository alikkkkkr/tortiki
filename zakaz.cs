using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;


namespace тортики
{
    internal class zakaz
    {
        public string vivodName;
        public int vivodCost;
        public void menu()
        {
            Console.WriteLine("  1. форма");
            Console.WriteLine("  2. размер");
            Console.WriteLine("  3. вкус");
            Console.WriteLine("  4. количество");
            Console.WriteLine("  5. глазурь");
            Console.WriteLine("  6. декор");
            Console.WriteLine("  чтобы завершить заказ нажмите Escape");
        }
        public List<tortiki> podmenu()
        {
            List<tortiki> tort = new List<tortiki>();
            tortiki zakaz1 = new tortiki(new string[] { "  круглый", "  квадратный", "  хлебная жаба" }, new int[] { 100, 200, 1000000 });
            tort.Add(zakaz1);
            tortiki zakaz2 = new tortiki(new string[] { "  маленький", "  средний", "  большой" }, new int[] { 100, 300, 500 });
            tort.Add(zakaz2);
            tortiki zakaz3 = new tortiki(new string[] { "  шоколадный", "  ягодки", "  бубл гум" }, new int[] { 100, 300, 500 });
            tort.Add(zakaz3);
            tortiki zakaz4 = new tortiki(new string[] { "  один коржик", "  два коржика", "  три коржа, жопа слипнется" }, new int[] { 200, 400, 700 });
            tort.Add(zakaz4);
            tortiki zakaz5 = new tortiki(new string[] { "  темный шоколад", "  ванильная", "  карамельная" }, new int[] { 50, 30, 70 });
            tort.Add(zakaz5);
            tortiki zakaz6 = new tortiki(new string[] { "  шоколадные жабы", "  ягодки", "  цветочки" }, new int[] { 800, 350, 550 });
            tort.Add(zakaz6);
            return tort;
        }
        public void PodmenuOutput(tortiki tortiki)
        {
            Console.Clear();
            for (int i = 0; i < tortiki.cost.Length; i++)
            {
                Console.WriteLine(tortiki.name[i] + " - " + tortiki.cost[i]);
            }
        }
        public void fail()
        {
            DateTime dataTime = DateTime.Now;
            File.AppendAllText("Users\\alinaryzhkova\\Desktop", "\n" + "\n" + dataTime + "\n" + "Ваш выбор:" + vivodName + "\n" + "Итого: " + vivodCost);
            Console.WriteLine("ваш заказ сохранен в истории заказов \nесли хотите сделать еще один заказ нажмите на пробел");
        }
    }
}