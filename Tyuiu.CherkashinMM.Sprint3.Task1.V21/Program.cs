using Tyuiu.CherkashinMM.Sprint3.Task1.V21.Lib; 
 
namespace Tyuiu.CherkashinMM.Sprint3.Task1.V21; 
 
class Program 
{ 
    static void Main(string[] args) 
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #3 | Выполнил: Черкашин М. М. | ИИПб-24-1";
        Console.WriteLine("************************************************************************");
        Console.WriteLine("* Спринт #3                                                            *");
        Console.WriteLine("* Тема: Алгоритмы циклической структуры                                *");
        Console.WriteLine("* Задание #1                                                           *");
        Console.WriteLine("* Вариант #21                                                          *");
        Console.WriteLine("* Выполнил: Черкашин Максим Михайлович | ИИПб-24-1                     *");
        Console.WriteLine("************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                             *");
        Console.WriteLine("* Написать программу используя цикл while, которая вычисляет           *");
        Console.WriteLine("* произведение ряда по формуле, при х=1                                *");
        Console.WriteLine("*                                                                      *");
        Console.WriteLine("************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                     *");
        Console.WriteLine("************************************************************************");

        Console.WriteLine("Введите переменную x:");
        int x = int.Parse(Console.ReadLine()!);
        Console.WriteLine("Введите переменную k1:");
        int y1 = int.Parse(Console.ReadLine()!);
        Console.WriteLine("Введите переменную k2:");
        int y2 = int.Parse(Console.ReadLine()!);

        Console.WriteLine("************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *");
        Console.WriteLine("************************************************************************");

        Console.WriteLine(ds.GetMultiplySeries(x, y1, y2));
    } 
} 
