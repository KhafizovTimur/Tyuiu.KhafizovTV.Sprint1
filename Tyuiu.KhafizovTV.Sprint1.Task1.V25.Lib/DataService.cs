using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.KhafizovTV.Sprint1.Task1.V25.Lib
{
    public class DataService : ISprint1Task1V25
    {
        public double Calculate(double x, double y)
        {
            double result = (x * y) / (1 + x);

            return Math.Round(result,2);
        }
    }
}