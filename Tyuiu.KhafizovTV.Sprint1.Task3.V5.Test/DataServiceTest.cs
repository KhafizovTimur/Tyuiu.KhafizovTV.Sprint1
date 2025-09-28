using Tyuiu.KhafizovTV.Sprint1.Task3.V5.Lib;

namespace Tyuiu.KhafizovTV.Sprint1.Task3.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double k = 120;
            double s = 3.5;
            double wait = 420.000;
            var res = ds.DistanceLength(k, s);
            Assert.AreEqual(wait, res);
        }
    }
}