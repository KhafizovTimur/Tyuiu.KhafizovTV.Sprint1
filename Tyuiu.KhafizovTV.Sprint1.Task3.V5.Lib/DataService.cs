using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.KhafizovTV.Sprint1.Task3.V5.Lib
{
    public class DataService : ISprint1Task3V5
    {
        public double DistanceLength(double k, double s)
        {
            return Math.Round(k * s, 3);
        }
    }
}