using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.MuliavinIM.Sprint5.Task5.V29.Lib
{
    public class DataService : ISprint5Task5V29
    {
        public double LoadFromDataFile(string path)
        {
            int min = 1000;
            double res = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string? line;
                while ((line = reader.ReadLine()) != null)
                {
                    string lineReplace = line.Replace('.', ',');
                    string[] lineArray = lineReplace.Split(' ');

                    foreach (string number in lineArray)
                    {
                        double lineParse = double.Parse(number);

                        if ((lineParse > 9) && (lineParse < 100))
                        {
                            res = lineParse;
                            while (res < min)
                            {
                                min = (int)res;
                            }
                        }
                    }
                }
            }
            return min;
        }
    }
}