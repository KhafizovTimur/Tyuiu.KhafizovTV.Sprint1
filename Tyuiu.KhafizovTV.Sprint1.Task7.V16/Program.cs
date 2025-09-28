using Tyuiu.KhafizovTV.Sprint1.Task7.V16.Lib;

namespace Tyuiu.KhafizovTV.Sprint1.Task7.V16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Хафизов Т. В. | ИСПб-25-1";
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Спринт #1                                                              *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                *");
            Console.WriteLine("* Задание #7                                                             *");
            Console.WriteLine("* Вариант #16                                                            *");
            Console.WriteLine("* Выполнил: Хафизов Т. В. | ИСПб-25-1                                    *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Написать программу, которая вычисляет математическое выражение         *");
            Console.WriteLine("* по исходным значениям данных, вводимых пользователем.       	      	*");
            Console.WriteLine("*                                                                        *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("                                                                          ");
            Console.WriteLine("                     cosx^2                                               ");
            Console.WriteLine("z = sin(sqrt(x^2)) + ------ - sin(sqrt(x^2-1))                            ");
            Console.WriteLine("                      3x^3                                                ");
            Console.WriteLine("                                                                          ");

            double x;
            Console.WriteLine("Введите значение x:");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");

            Console.WriteLine("z = " + $"{ds.Calculate(x):F3}");

            Console.ReadKey();
        }
    }
}