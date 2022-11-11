using System;
using System.Dynamic;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Numerics;
using System.Drawing;

namespace симулятор_торта
{
    
    internal class commission
    {
        public static void full(int sumin, List<string> cake)
        {
            string a = string.Join(", ", cake);
            File.AppendAllText("C:\\Рабочий стол\\caсke\\Заказ_торта.txt", "Заказ от: " + DateTime.Today + "\n");
            File.AppendAllText("C:\\Рабочий стол\\caсke\\Заказ_торта.txt", "Торт: " + a + "\n");
            File.AppendAllText("C:\\Рабочий стол\\caсke\\Заказ_торта.txt", "Сумма заказа: " + sumin + "\n" + "\n");
        }
        commission[] commission1 = new commission[6];
        public string[] title = new string[5];
        public int[] price = new int[5];
        commission(string[] name, int[] cost)
        {
            commission shape = new commission(new string[] { "Круглый", "Квадратный", "Треугольный", "Сердечко", "Особая" }, new int[] { 500, 750, 350, 700, 1000 });
            commission size = new commission(new string[] { "Маленький", "Средний", "Большой", "На заказ", "Свадебный" }, new int[] { 2000, 4000, 5000, 7500, 7500 });
            commission taste = new commission(new string[] { "Ванильный", "Шоколадный", "Карамельный", "Ягодный", "Экзотический" }, new int[] { 1000, 1000, 2000, 750, 4000 });
            commission amount = new commission(new string[] { "1 корж", "2 коржа", "3 коржа", "4 коржа", "5 коржей" }, new int[] { 1500, 1750, 2000, 2250, 2500 });
            commission glaze = new commission(new string[] { "Шоколад", "Крем", "Бизе", "Драже", "Ягоды"}, new int[] { 500, 750, 550, 750, 750 });
            commission decor = new commission(new string[] { "Шоколадная", "Арахис", "Кремовая", "Особая", "Особая ++" }, new int[] { 1250, 1000, 1500, 2000, 2500 });
            commission1 = new commission[] { shape, size, taste, amount, glaze, decor };
        }
        public static commission Menu(int posin)
        {
            commission menupart = commission1[posin];
            return menupart;
        }
    }
}
