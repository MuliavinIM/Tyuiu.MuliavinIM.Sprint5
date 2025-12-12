using Tyuiu.MuliavinIM.Sprint5.Task1.V4.Lib;

Console.Title = "Спринт #5 | Выполнил: Мулявин.И.М.  | ИСТНб-25-1 ";
Console.WriteLine("************************************************************************");
Console.WriteLine("* Спринт #5                                                            *");
Console.WriteLine("* Тема: Класс File. Запись набора данных в текстовый файл              *");
Console.WriteLine("* Задание #1                                                           *");
Console.WriteLine("* Вариант #4                                                           *");
Console.WriteLine("* Выполнил: Мулявин Иван Михайлович | ИСТНб-25-1                       *");
Console.WriteLine("************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                             *");
Console.WriteLine("* Дана функция, произвести табулирование.                              *");
Console.WriteLine("************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *");
Console.WriteLine("************************************************************************");

Console.WriteLine(new DataService().SaveToFileTextData(-5, 5));
Console.ReadKey();