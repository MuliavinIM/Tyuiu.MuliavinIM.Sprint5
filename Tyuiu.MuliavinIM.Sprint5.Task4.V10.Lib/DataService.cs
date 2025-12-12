using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.MuliavinIM.Sprint5.Task4.V10.Lib
{
    public class DataServise : ISprint5Task4V10
    {
        public double LoadFromDataFile(string path)
        {
            string strX = File.ReadAllText(path);
            double x = double.Parse(strX.Replace('.', ','));
            double res = Math.Pow(x, 3) * 1.2 * x + 2;
            res = Math.Round(res, 3);

            return res;
        }
    }
}