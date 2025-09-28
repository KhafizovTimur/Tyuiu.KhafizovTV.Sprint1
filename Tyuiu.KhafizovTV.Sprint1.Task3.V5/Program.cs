using Tyuiu.KhafizovTV.Sprint1.Task3.V5.Lib;

namespace Tyuiu.KhafizovTV.Sprint1.Task3.V5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Хафизов Т. В. | ИСПб-25-1";
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Спринт #1                                                              *");
            Console.WriteLine("* Тема: Операторы составного присваивания                                *");
            Console.WriteLine("* Задание #3                                                             *");
            Console.WriteLine("* Вариант #5                                                             *");
            Console.WriteLine("* Выполнил: Хафизов Т. В. | ИСПб-25-1                                    *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные,*");
            Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.           	*");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");

            Console.Write("Введите масштаб карты (км в 1 см): ");
            double k = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите расстояние между точками, изображающими населенные пункты (см): ");
            double s = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");

            double result = ds.DistanceLength(k, s);
            Console.WriteLine($"Расстояние между населенными пунктами = {result:F3}");
            Console.ReadKey();

        }
    }
}