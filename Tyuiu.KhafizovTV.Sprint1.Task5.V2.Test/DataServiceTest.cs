using Tyuiu.KhafizovTV.Sprint1.Task5.V2.Lib;

namespace Tyuiu.KhafizovTV.Sprint1.Task5.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 127;
            double wait = 52.000;
            var res = ds.FahrenheitToСelsius(x);
            Assert.AreEqual(wait, res);
        }
    }
}