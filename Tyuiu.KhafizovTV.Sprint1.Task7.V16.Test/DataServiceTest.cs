using Tyuiu.KhafizovTV.Sprint1.Task7.V16.Lib;

namespace Tyuiu.KhafizovTV.Sprint1.Task7.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 100;
            double wait = 0.004;
            var res = ds.Calculate(x);
            Assert.AreEqual(wait, res);
        }
    }
}