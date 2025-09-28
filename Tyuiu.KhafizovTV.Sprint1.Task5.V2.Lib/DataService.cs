using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.KhafizovTV.Sprint1.Task5.V2.Lib
{
    public class DataService : ISprint1Task5V2
    {
        public int FahrenheitToСelsius(double temp)
        {
            double res = (temp - 32) * (5.0 / 9.0);
            return (int)res;
        }
    }
}