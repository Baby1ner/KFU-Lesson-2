using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KFU_2_Lesson
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Задание 1. Вывести на экран число е");
            Console.WriteLine("e =  2,7");



            Console.WriteLine("Задание 2. Вывести на экран числа 50 и 10 одно под другим");
            Console.WriteLine("50");
            Console.WriteLine("10");



            Console.WriteLine("Задание 3. Вывести на экран 4 cлучайных числа столбиком");
            Random x228 = new Random();
            int n01234 = x228.Next();
            Console.WriteLine(n01234); // немного неудобно все заданияписать в 
            int n1234 = x228.Next();   // в одном коде тк кончаются удобные буквы
            Console.WriteLine(n1234);  // ^_^
            int n234 = x228.Next();
            Console.WriteLine(n234);
            int n34 = x228.Next();
            Console.WriteLine(n34);



            Console.WriteLine("Задание 4. Вывести число больше на 10 чем введеное");
            Console.WriteLine("Введите число");
            string a4 = Console.ReadLine();
            int a41 = Convert.ToInt32(a4);
            Console.WriteLine($"ваше число = {a41 + 10}");



            Console.WriteLine("Задание 5. Дана сторона квадрата найти периметр");
            Console.WriteLine("Введите число");
            string a5 = Console.ReadLine();
            int a51 = Convert.ToInt32(a5);
            int a52 = a51 * 4;
            Console.WriteLine($"периметр = {a52}");



            Console.WriteLine("Задание 6.Дан Радиус Найти длину окр и площадь");
            int a6 = int.Parse(Console.ReadLine());
            Console.WriteLine($"Длина окружности = {a6 * 2 * 3.14} Площадь круга = {a6 * a6 * 3.14}");



            Console.WriteLine("Задание 7. Найти y=cos(x)");
            Console.WriteLine("Введите x");
            float x7 = float.Parse(Console.ReadLine());
            double y7 = Math.Cos(x7);
            Console.WriteLine($"y = {y7}");



            Console.WriteLine("Задание 8. Найти периметр равнобедренной трапеции ");
            Console.WriteLine("Введите высоту рб. Трап.");
            int visota8 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите большее основание рб. Трап.");
            int bolshosn8 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите меньшее основание рб. Трап.");
            int menshosn8 = int.Parse(Console.ReadLine());
            Console.WriteLine($"Плщадь = {visota8 * ((bolshosn8 + menshosn8) / 2)}");



            Console.WriteLine("Задание 9. Найти стоимость всей покупки если известна цена товара");
            Console.WriteLine("Введите сколько куплено кг конфет по 50 руб за кг");
            float x9 = float.Parse(Console.ReadLine());
            Console.WriteLine("Введите сколько куплено кг печения по 35 руб за кг");
            float y9 = float.Parse(Console.ReadLine());
            Console.WriteLine("Введите сколько куплено кг яблок по 15 руб за кг");
            float z9 = float.Parse(Console.ReadLine());
            Console.WriteLine($"Стоимость покупки ={x9 * 50 + y9 * 35 + z9 * 15}");



            Console.WriteLine("Задание 10. код который выводит Мир Труд Май");
            Console.WriteLine("Мир " + "Труд " + "Май");
            Console.WriteLine("Мир");     // Считается ли это за читерство?
            Console.WriteLine("    Труд");
            Console.WriteLine("          Май");



            Console.WriteLine("Задание 11. Не смог сделать");



            Console.WriteLine("Задание 12. В зависимости от фигуры вычислить площ или перим");
            Console.WriteLine("Если фигура правильный треугольник введите 1, если четырехугольник то 2, если круг 3");
            int figur12 = int.Parse(Console.ReadLine());
            Console.WriteLine("Если нужно найти периметр введите 1, площадь 2");
            int Naiti12 = int.Parse(Console.ReadLine());
            if (figur12 == 1)
            {
                Console.WriteLine("Введите сторону треугольника");
                float storon121 = float.Parse(Console.ReadLine());
                if (Naiti12 == 1)
                {
                    Console.WriteLine($"Периметр Треугольника = {storon121 * 3}");
                }
                else
                {
                    Console.WriteLine($"Площадь Треугольника = {storon121 * storon121 * 1.73 / 4}");
                }
            }
            if (figur12 == 3) ;
            {
                Console.WriteLine("Введите радиус круга");
                float storon123 = float.Parse(Console.ReadLine());
                if (Naiti12 == 1)
                {
                    Console.WriteLine($"Периметр Круга = {storon123 * 2 * 3.14}");
                }
                else
                {
                    Console.WriteLine($"Площадь Круга = {storon123 * storon123 * 3.14}");
                }
            }



            Console.WriteLine("Задание 13. Вывод на экран число которое вводили с клавы");
            float a13 = float.Parse(Console.ReadLine());
            Console.WriteLine($"Вы ввели число {a13}"); //А задания не по сложности чтоль?



            Console.WriteLine("Задание 14. программу вывода на экран следующей информации:");
            Console.WriteLine("2 кг");
            Console.WriteLine("13 17");



            Console.WriteLine("Задание 15. Вывести на экран 4 cлучайных числа столбиком");
            Random x15 = new Random();
            int n151 = x15.Next();
            Console.WriteLine(n151); // опять это задание ¯\_(ツ)_/¯ 
            int n152 = x15.Next();   // Very strange
            Console.WriteLine(n152);
            int n153 = x15.Next();
            Console.WriteLine(n153);
            int n154 = x15.Next();
            Console.WriteLine(n154);



            Console.WriteLine("Задание 16. Найти корни квадратного уравнения");
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



            Console.WriteLine("Задание 17. Найти ср геометрическое и арифметическое 2 чисел");
            Console.WriteLine("Введите 1 число");
            float a171 = float.Parse(Console.ReadLine());
            Console.WriteLine("Введите 2 число");
            float a172 = float.Parse(Console.ReadLine());
            Console.WriteLine($"Cреднее арифметическое = {(a171 + a172) / 2}");
            Console.WriteLine($"Cреднее геометрическое = {Math.Sqrt(a171 * a172)}");



            Console.WriteLine("Задание 18. Найти расстояние между 2 точками плоскости");
            Console.WriteLine("Введите y1");
            float y181 = float.Parse(Console.ReadLine());
            Console.WriteLine("Введите x1");
            float x181 = float.Parse(Console.ReadLine());
            Console.WriteLine("Введите y2");
            float y182 = float.Parse(Console.ReadLine());
            Console.WriteLine("Введите x2");
            float x182 = float.Parse(Console.ReadLine());
            Console.WriteLine($"Растояние между точками = {Math.Sqrt((x182 - x181) * (x182 - x181) + (y182 - y181) * (y182 - y181))}");



            Console.WriteLine("Задание 19.Составить программу обмена значениями трех переменных величин");
            Console.WriteLine("Введите число а");
            float a18 = float.Parse(Console.ReadLine());
            Console.WriteLine("Введите число b");
            float b18 = float.Parse(Console.ReadLine());
            Console.WriteLine("Введите число c");
            float c18 = float.Parse(Console.ReadLine());
            float ahelper18 = a18; //помошник
            float bhelper18 = b18; //помошник
            float chelper18 = c18; //помошник
            b18 = chelper18;  // номер а
            a18 = bhelper18;
            c18 = ahelper18;
            Console.WriteLine($"a) a = {a18} b = {b18} c = {c18}");
            b18 = ahelper18;  // номер б
            a18 = chelper18;
            c18 = bhelper18;
            Console.WriteLine($"a) a = {a18} b = {b18} c = {c18}");



            Console.WriteLine("Задание 20.С начала суток прошло n секунд. Определить:");
            Console.WriteLine("Cколько прошло секунд");
            int n20 = int.Parse(Console.ReadLine());
            Console.WriteLine($"а) Прошло {n20 / 3600} часа(ов)");
            int n201 = (n20 - ((n20 / 3600) * 3600)) / 60;
            Console.WriteLine($"б) С начала часа прошло {n201} минут(ы)");
            int n202 = (n20 - (((((n20 / 3600) * 3600) / 60) * 60) + n201 * 60));
            Console.WriteLine($"в) С начала минуты прошло {n202} секунд(ы)");



            Console.WriteLine("Задание 21.Дан прямоугольник сколько от него можно отрезать квадратов");
            Console.WriteLine($"Можно вырезать {543 / 130} квадрата");



            Console.WriteLine("Задание 22.Дано трехзначное число поменять местами 1 и последнюю цифру");
            Console.WriteLine("Введите число");
            int n22 = int.Parse(Console.ReadLine());
            int a22 = n22 % 10;
            Console.WriteLine($"Новое число = {(n22 / 10) + (a22 * 100)}");



            Console.WriteLine("Задание 23.Дано число >1000 найти число сотен и число тысяч");
            Console.WriteLine("Введите число");
            int a23 = int.Parse(Console.ReadLine());
            Console.WriteLine($"Число сотен = {(a23 / 100) % 10}");
            Console.WriteLine($"Число тысяч = {(a23 / 1000) % 10}");



            Console.WriteLine("Задание 24.Дано 4 значное число переделать его");
            Console.WriteLine("Введите число");
            string ak24 = Console.ReadLine();
            string chislo124 = char.ToString(ak24[0]);
            string chislo224 = char.ToString(ak24[1]);
            string chislo324 = char.ToString(ak24[2]);
            string chislo424 = char.ToString(ak24[3]);
            Console.WriteLine($"а)слева направо Число = {Convert.ToInt64(chislo424 + chislo324 + chislo224 + chislo124)}");
            Console.WriteLine($"б)перестановка первой и вотрой,третей и четвертой Число = {Convert.ToInt64(chislo224 + chislo124 + chislo424 + chislo324)}");
            Console.WriteLine($"в)перестановка 2 и 3 Число = {Convert.ToInt64(chislo124 + chislo324 + chislo224 + chislo424)}");
            Console.WriteLine($"г)перестановка 1 и 2 с 3 и 4 Число = {Convert.ToInt64(chislo324 + chislo424 + chislo124 + chislo224)}");



            Console.WriteLine("Задание 25. Из трехзначного числа x вычли его последнюю цифру. Когда результат разделили\r\nна 10, а к частному слева приписали последнюю цифру числа x, то получилось\r\nчисло n. Найти число x.");
            Console.WriteLine("Введите число такое что 100 < n < 999");
            string ak25 = Console.ReadLine();
            string chislo125 = char.ToString(ak25[0]);
            string chislo225 = char.ToString(ak25[1]);
            string chislo325 = char.ToString(ak25[2]);
            Console.WriteLine($" Число х = {Convert.ToInt64(chislo325 + chislo225 + chislo125)}");



            Console.WriteLine("Задание 26.Дано время, сказать на сколько сдвинулась градусов часовая стрелка");
            Console.WriteLine("Введите сколько часов прошло 0 < h < 23");
            int chas26 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите сколько минут прошло 0 < h < 60");
            int min26 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите сколько секунд прошло 0 < h < 60");
            int sec26 = int.Parse(Console.ReadLine());
            if (chas26 < 12)
            {
                Console.WriteLine($"Стрелка прошла {(chas26 * 30) + (min26 * 0.5) + (sec26 * 0.00833)} градусов");

            }
            if (chas26 >= 12)
            {
                Console.WriteLine($"Стрелка прошла {((chas26 - 12) * 30) + (min26 * 0.5) + (sec26 * 0.00833)} градусов");

            }



            Console.WriteLine("Задание 27.Задание некоректно написанно, или я непонял");



            Console.WriteLine("Задание 28.Создать программу, которая будет выводить на экран меньшее по модулю из трёх\r\nвведённых пользователем вещественных чисел");
            Console.WriteLine("Введите 1 число");
            float a28 = float.Parse(Console.ReadLine());
            Console.WriteLine("Введите 2 число");
            float b28 = float.Parse(Console.ReadLine());
            Console.WriteLine("Введите 3 число");
            float c28 = float.Parse(Console.ReadLine());
            if (Math.Abs(a28) <= Math.Abs(b28))
            {
                if (Math.Abs(a28) <= Math.Abs(c28))
                {
                    Console.WriteLine(a28);
                }
            }
            if (Math.Abs(c28) <= Math.Abs(b28))
            {
                if (Math.Abs(c28) <= Math.Abs(a28))
                {
                    Console.WriteLine(c28);
                }
            }
            if (Math.Abs(b28) <= Math.Abs(a28))
            {
                if (Math.Abs(b28) <= Math.Abs(c28))
                {
                    Console.WriteLine(b28);
                }
            }



            Console.WriteLine("Задание 29. Найти сумму большего и меньшего из трёх заданных чисел");
            Console.WriteLine("Введите 1 число");
            float a29 = float.Parse(Console.ReadLine());
            Console.WriteLine("Введите 2 число");
            float b29 = float.Parse(Console.ReadLine());
            Console.WriteLine("Введите 3 число");
            float c29 = float.Parse(Console.ReadLine());

            float maxim29 = Math.Max(a29, b29);
            float maximus29 = Math.Max(maxim29, c29);
            float minim29 = Math.Min(a29, b29);
            float minimus29 = Math.Min(minim29, c29);
            Console.WriteLine($"Сумма макс и мин числа = {maximus29 + minimus29}");



            Console.WriteLine("Задание 30.Подсчитать общее количество делителей натурального числа");
            Console.WriteLine("Введите число");
            int a30 = int.Parse(Console.ReadLine());
            float a300 = Convert.ToSingle(a30);
            int c30 = 0;
            for (int i30 = 1; i30 <= a30; i30++)
                if (a30 % i30 == 0)
                {
                    c30++;
                }
            Console.WriteLine(c30);



            Console.WriteLine("Задание 31.Решание уравнения перебором");
            Console.WriteLine("Введите a");
            float a31 = float.Parse(Console.ReadLine());
            Console.WriteLine("Введите b");
            float b31 = float.Parse(Console.ReadLine());
            Console.WriteLine("Введите c");
            float c31 = float.Parse(Console.ReadLine());
            Console.WriteLine("Введите d");
            float d31 = float.Parse(Console.ReadLine());

            for (int i31 = -100; i31 < 100; i31++)
                if ((a31 * i31 * i31 * i31) + (i31 * i31 * b31) + (i31 * c31) + d31 == 0)
                {
                    Console.WriteLine($" X = {i31}");
                }



            Console.WriteLine("Задание 32.Заданы первый и второй элементы арифметической прогрессии. Требуется\r\nнаписать программу, которая вычислит элемент прогрессии по ее номеру.");
            Console.WriteLine("Введите 1 число последовательности");
            float a32 = float.Parse(Console.ReadLine());
            Console.WriteLine("Введите 2 число последовательности");
            float b32 = float.Parse(Console.ReadLine());
            Console.WriteLine("Введите номер числа последовательности");
            float c32 = float.Parse(Console.ReadLine());
            Console.WriteLine($"Твое число ={(b32 - a32) * c32} ");



            Console.WriteLine("Задание 33.Получу ли я кредит");
            Console.WriteLine("Напиши ты студент или пенсионер (с маленькой), если оба пиши  студентпенсионер");
            string kto33 = Console.ReadLine();
            Console.WriteLine("Ты трудоустроен да нет (с маленькой)");
            string trud33 = Console.ReadLine();
            if (kto33 != "студент")
            {
                if (kto33 != "пенсионер")
                {
                    Console.WriteLine("Обслуживаем только пенсионеров или студентов");
                }
                if (trud33 == "да")
                {
                    if (kto33 == "студент")
                    {
                        Console.WriteLine("Не получишь кредит");
                    }
                    if (kto33 == "пенсионер")
                    {
                        Console.WriteLine("Не получишь кредит");
                    }

                }
            }
            if (trud33 == "нет")
            {
                if (kto33 == "студент")
                {
                    Console.WriteLine("Ты получишь кредит");
                }
                if (kto33 == "пенсионер")
                {
                    Console.WriteLine("Ты получишь кредит");
                }
            }
            if (kto33 == "студентпенсионер")
            {
                Console.WriteLine("Не получишь кредит");
            }



            Console.WriteLine("Задание 34. Как тебя зовут");
            Console.WriteLine("Напиши как тебя зовут");
            string a34 = Console.ReadLine();
            Console.WriteLine(a34);
            Console.WriteLine(" Привет " + a34);



            Console.WriteLine("Задание 35. Разговоры с дневником. Не знаю как решить");// У меня уже беды с бошкой время 23.10 дедлайн немного осталось



            Console.WriteLine("Задание 36.Не знаю как решить");




        }
    }
}