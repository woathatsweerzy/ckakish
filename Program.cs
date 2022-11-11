using System.Dynamic;
using System.IO;
namespace симулятор_торта
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                menu();
                Console.WriteLine("Escape чтобы повторить заказ");
                ConsoleKeyInfo key = Console.ReadKey();
                Console.Clear();
                main_menu();
                if (key.Key != ConsoleKey.Escape)
                {
                    break;
                }
            }
            Console.Clear();
        }
        static void main_menu()
        {
            Console.WriteLine("Заказ тортов в МАСЮНЬКА, мы печем самые трушные торты!");
            Console.WriteLine("Параметры торта");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("  Форма");
            Console.WriteLine("  Размер");
            Console.WriteLine("  Вкус коржей");
            Console.WriteLine("  Количество коржей");
            Console.WriteLine("  Глазурь");
            Console.WriteLine("  Декор");
            Console.WriteLine("  Конец заказа");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Цена торта: ");
            Console.WriteLine("Торт: ");
        }
        static int Pos(ConsoleKeyInfo key_1, int pos_2)
        {
            if (key_1.Key == ConsoleKey.DownArrow)
            {
                pos_2++;
            }
            if (key_1.Key == ConsoleKey.UpArrow)
            {
                pos_2--;
            }
            return pos_2;
        }
        static void menu()
        {
            ConsoleKeyInfo key = Console.ReadKey();
            int pos = 3;
            int costs = 0;
            List<string> name = new List<string>();
            while (true)
            {
                Console.Clear();
                main_menu();
                pos = Pos(key, pos);
                if (pos < 3)
                {
                    pos = 3;
                }
                if (pos > 12)
                {
                    pos = 12;
                }
                Console.SetCursorPosition(0, pos);
                Console.WriteLine("->");
                if (key.Key == ConsoleKey.Enter && pos == 9)
                {
                    Console.Clear();

                    break;
                }
                if (key.Key == ConsoleKey.Enter)
                {
                    Console.Clear();
                    var a = Menu2(key, pos);
                    Console.Clear();
                    main_menu();
                    costs = costs + a.Item1;
                    name.Add(a.Item2);
                }
                Console.SetCursorPosition(7, 11);
                Console.WriteLine(costs);
                Console.SetCursorPosition(11, 12);
                foreach (string i in name)
                {
                    Console.Write(i);
                    Console.Write(", ");
                }
                ConsoleKeyInfo key_1 = Console.ReadKey();
                key = key_1;
                Console.Clear();
            }
            Console.Clear();
            commission.full(costs, name);
        }

        static Tuple<int, string> Menu2(ConsoleKeyInfo key1, int pos_1)
        {
            string elements = "";
            int summ = 0;
            int pos1 = 0;
            string a = "";
            int b = 0;
            while (true)
            {
                int positioning = pos_1 - 3;
                commission menupart = commission.Menu(positioning);
                for (int i = 0; i < 5; i++)
                {
                    a = menupart.title[i];
                    b = menupart.price[i];
                    Console.Write("  ");
                    Console.Write(a);
                    Console.Write(" - ");
                    Console.WriteLine(b);
                }

                pos1 = Pos(key1, pos1);
                if (pos1 < 0)
                {
                    pos1 = 4;
                }
                if (pos1 > 4)
                {
                    pos1 = 0;
                }
                Console.SetCursorPosition(0, pos1);
                Console.WriteLine("->");
                ConsoleKeyInfo key_1 = Console.ReadKey();
                key1 = key_1;
                Console.Clear();
                if (key_1.Key == ConsoleKey.Enter)
                {
                    summ = menupart.price[pos1];
                    elements = menupart.title[pos1];
                    break;
                }
            }
            return Tuple.Create(summ, elements);
        }
    }
}