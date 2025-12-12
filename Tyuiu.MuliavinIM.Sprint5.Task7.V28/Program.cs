using Tyuiu.MuliavinIM.Sprint5.Task7.V28.Lib;
namespace Tyuiu.MuliavinIM.Sprint5.Task7.V28
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Мулявин.И.М.  | ИСТНб-25-1 ";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #28                                                             *");
            Console.WriteLine("* Выполнил: Мулявин Иван Михайлович |  ИСТНб-25-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Заменить все пробелы, идущие подряд более одного, на один пробел.       *");
            Console.WriteLine("* Полученный результат сохранить в файл OutPutDataFileTask7V28.txt.       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");



            string path = Path.Combine(new string[] { "C:", "DataSprint5", "InPutDataFileTask7V28.txt" });
            string pathSaveFile = Path.Combine(new string[] { "C:", "DataSprint5", "OutPutDataFileTask7V28.txt" });

            Console.WriteLine("Данные находятся в файле: " + path);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");


            pathSaveFile = ds.LoadDataAndSave(path);

            Console.WriteLine("Результат сохранён в: " + pathSaveFile);
            Console.ReadKey();
        }
    }
}