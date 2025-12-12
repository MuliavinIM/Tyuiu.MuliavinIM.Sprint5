using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.MuliavinIM.Sprint5.Task1.V4.Lib;
public class DataService : ISprint5Task1V4
{
    public string SaveToFileTextData(int startValue, int stopValue)
    {
        string output = string.Empty;
        for (int i = startValue; i <= stopValue; i++)
        {
            double value;
            if (i != -1)
                value = Math.Round(f(i), 2);
            else
                value = 0;
            output += value + "\n";
        }

        output = output[..^1];

        string path = Path.GetTempFileName();

        File.WriteAllText(path, output);

        return output;
    }

    private double f(double x) => Math.Cos(x) / (x + 1) - Math.Cos(x) * 1.3 + 3 * x;
}