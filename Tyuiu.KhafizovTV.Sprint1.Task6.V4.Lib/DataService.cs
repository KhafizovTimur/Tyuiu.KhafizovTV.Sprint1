using System.Text.RegularExpressions;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.KhafizovTV.Sprint1.Task6.V4.Lib
{
    public class DataService : ISprint1Task6V4
    {
        public string CheckDoubleN(string value)
        {
            if (string.IsNullOrEmpty(value))
                return string.Empty;

            var words = Regex.Matches(value, @"[A-Za-zА-Яа-яЁё]+(?:-[A-Za-zА-Яа-яЁё]+)*");

            List<string> result = new();
            foreach (Match m in words)
            {
                string w = m.Value;
                if (w.IndexOf("нн", StringComparison.OrdinalIgnoreCase) >= 0)
                    result.Add(w);
            }

            return string.Join(" ", result);
        }
    }
}