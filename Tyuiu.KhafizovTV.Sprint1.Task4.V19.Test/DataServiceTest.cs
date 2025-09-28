using Tyuiu.KhafizovTV.Sprint1.Task4.V19.Lib;

namespace Tyuiu.KhafizovTV.Sprint1.Task4.V19.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 3;
            double y = 5;
            double wait = 2.828;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}