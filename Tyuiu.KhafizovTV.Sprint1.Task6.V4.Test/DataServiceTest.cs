using Tyuiu.KhafizovTV.Sprint1.Task6.V4.Lib;

namespace Tyuiu.KhafizovTV.Sprint1.Task6.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            string input = "Длинный запрос содержит временные ограничения";
            DataService ds = new DataService();
            string res = ds.CheckDoubleN(input);
            string wait = "Длинный временные";

            Assert.AreEqual(wait, res);
        }
    }
}