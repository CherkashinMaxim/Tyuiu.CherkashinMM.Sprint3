using Tyuiu.CherkashinMM.Sprint3.Task0.V11.Lib; 
 
namespace Tyuiu.BarbashinAV.Sprint3.Task0.V11; 
 
class Program 
{ 
    static void Main(string[] args) 
    { 
        Console.Title = "Спринт #3 | Выполнил: Черкашин М. М. | ИИПб-24-1"; 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* Спринт #3                                                            *"); 
        Console.WriteLine("* Тема:                                                                *"); 
        Console.WriteLine("* Задание #0                                                           *"); 
        Console.WriteLine("* Вариант #11                                                          *"); 
        Console.WriteLine("* Выполнил: Черкашин Максим Михайлович | ИИПб-24-1                                                           *"); 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* УСЛОВИЕ:                                                             *"); 
        Console.WriteLine("*                                                                      *"); 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                     *"); 
        Console.WriteLine("************************************************************************"); 
 
        Console.WriteLine("Введите переменную n:"); 
        int n = int.Parse(Console.ReadLine()!);
        Console.WriteLine("Введите переменную k1:");
        int k1 = int.Parse(Console.ReadLine()!);
        Console.WriteLine("Введите переменную k2:");
        int k2 = int.Parse(Console.ReadLine()!); 
        
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *"); 
        Console.WriteLine("************************************************************************"); 
 
        DataService ds = new DataService();
        Console.WriteLine(ds.GetSumSeries(n, k1, k2)); 
    } 
} 
