using Tyuiu.CherkashinMM.Sprint3.Task2.V2.Lib; 
 
namespace Tyuiu.CherkashinMM.Sprint3.Task2.V2; 
 
class Program 
{ 
    static void Main(string[] args) 
    { 
        Console.Title = "Спринт #3 | Выполнил: Черкашин М. М. | ИИПб-24-1"; 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* Спринт #3                                                            *");
        Console.WriteLine("* Тема: Алгоритмы циклической структуры                                *");
        Console.WriteLine("* Задание #2                                                           *"); 
        Console.WriteLine("* Вариант #2                                                           *"); 
        Console.WriteLine("* Выполнил: Черкашин Максим Михайлович | ИИПб-24-1                     *"); 
        Console.WriteLine("************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                             *");
        Console.WriteLine("* Написать программу используя цикл do...while, которая вычисляет      *");
        Console.WriteLine("* произведение ряда по формуле                                         *");
        Console.WriteLine("*                                                                      *");
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                     *"); 
        Console.WriteLine("************************************************************************"); 
 
        Console.WriteLine("Введите переменную k1:"); 
        int k1 = int.Parse(Console.ReadLine()!); 
        Console.WriteLine("Введите переменную k2:"); 
        int k2 = int.Parse(Console.ReadLine()!); 
 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *"); 
        Console.WriteLine("************************************************************************"); 
 
        DataService ds = new DataService();
        Console.WriteLine(ds.GetMultiplySeries(k1, k2));
    } 
} 
