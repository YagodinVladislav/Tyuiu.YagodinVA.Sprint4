using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.YagodinVA.Sprint4.Task6.V21.Lib;
namespace Tyuiu.YagodinVA.Sprint4.Task6.V21
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            string[] names = new string[] { "Facebook", "Twitter", "Instagram", "Snapchat", "LinkedIn", "Pinterest", "Reddit" };
            Console.Title = "Спринт #4 | Выполнил: Ягодин В.А. | АСОиУБ-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Класс Array                                                       *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #21                                                             *");
            Console.WriteLine("* Выполнил: Ягодин Владислав Александрович | АСОиУБ-23-2                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан строковый массив данных. Используя класс Array, подсчитайте         *");
            Console.WriteLine("* количество элементов, длина которых меньше 8.                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.Write("Массив: {");
            for (int i = 0; i < names.Length; i++)
            {
                Console.Write(names[i]);
                if (i != names.Length - 1) { Console.Write(", "); }
            }
            Console.WriteLine("}");
            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            int res = ds.Calculate(names);
            Console.WriteLine($"Количество элементов, длина которых меньше 8: {res}");
            Console.ReadKey();
        }
    }
}
