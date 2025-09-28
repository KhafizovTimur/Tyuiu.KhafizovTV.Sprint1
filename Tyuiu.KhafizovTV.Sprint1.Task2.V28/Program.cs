using Tyuiu.KhafizovTV.Sprint1.Task2.V28.Lib;

namespace Tyuiu.KhafizovTV.Sprint1.Task2.V28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Хафизов Т. В. | ИСПб-25-1";
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Спринт #1                                                              *");
            Console.WriteLine("* Тема: Арифметические операторы в C#                                    *");
            Console.WriteLine("* Задание #2                                                             *");
            Console.WriteLine("* Вариант #28                                                            *");
            Console.WriteLine("* Выполнил: Хафизов Т. В. | ИСПб-25-1                                    *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные,*");
            Console.WriteLine("* вычисляет значение градусов Кельвина и печатает его на экране.         *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");

            int c;

            Console.WriteLine("Введите значение градусов Цельсия:");
            c = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");

            Console.WriteLine("Градусы Кельвина = " + ds.ConvertCelsiusToKelvin(c));

            Console.ReadLine();
        }
    }
}