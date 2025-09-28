using Tyuiu.KhafizovTV.Sprint1.Task2.V28.Lib;

namespace Tyuiu.KhafizovTV.Sprint1.Task2.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int c = 25;
            var res = ds.ConvertCelsiusToKelvin(c);
            Assert.AreEqual(298, res);
        }
    }
}