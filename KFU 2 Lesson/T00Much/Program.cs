using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T00Much
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Упражнение 2.1 Привет имя");
            string a = Console.ReadLine();
            Console.WriteLine($"Привет {a}");


            Console.WriteLine("Упражнение 2.2 Деление");
            Console.WriteLine("Введите делимое");
            float del = float.Parse(Console.ReadLine());
            Console.WriteLine("Введите делитель");
            float delit = float.Parse(Console.ReadLine());
            if (delit == 0)
            {
                Console.WriteLine("Ты шо больной?");
            }
            else
            {
                Console.WriteLine(del / delit);
            }



            Console.WriteLine("Дом.Задание 2.1 Следующая буква алфавита");
            Console.WriteLine("Введите букву");
            string bukv = Console.ReadLine();
            int nomer = char.Parse(bukv);
            if (bukv != "z")
            {
                Console.WriteLine((char)(nomer + 1));

            }
            else
            {
                Console.WriteLine("a");
            }


            Console.WriteLine("Дом.Задание 2.2 Решение квадратного уравнения");
            Console.WriteLine("Введите коэфицент а");
            float a16 = float.Parse(Console.ReadLine());
            Console.WriteLine("Введите коэфицент b");
            float b16 = float.Parse(Console.ReadLine());
            Console.WriteLine("Введите коэфицент c");
            float c16 = float.Parse(Console.ReadLine());
            if (b16 * b16 - 4 * a16 * c16 > 0)
            {
                Console.WriteLine($"X1 = {(-b16 + Math.Sqrt(b16 * b16 - 4 * a16 * c16)) / (a16 * 2)}");
                Console.WriteLine($"X2 = {(-b16 - Math.Sqrt(b16 * b16 - 4 * a16 * c16)) / (a16 * 2)}");
            }
            if (b16 * b16 - 4 * a16 * c16 == 0)
            {
                Console.WriteLine($" Одно решение X = {(-b16 + Math.Sqrt(b16 * b16 - 4 * a16 * c16)) / (a16 * 2)}");

            }
            if (b16 * b16 - 4 * a16 * c16 < 0)
            {
                Console.WriteLine("Нет решений :-/");
            }
        }
    }
}
