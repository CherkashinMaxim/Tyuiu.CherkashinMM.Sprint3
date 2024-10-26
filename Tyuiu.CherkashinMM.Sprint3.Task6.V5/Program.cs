using Tyuiu.CherkashinMM.Sprint3.Task6.V5.Lib; 
 
namespace Tyuiu.BarbashinAV.Sprint3.Task6.V5; 
 
class Program 
{ 
    static void Main(string[] args) 
    { 
        Console.Title = "Спринт #3 | Выполнил: Черкашин М. М. | ИИПб-24-1"; 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* Спринт #3                                                            *"); 
        Console.WriteLine("* Тема:                                                                *"); 
        Console.WriteLine("* Задание #6                                                           *"); 
        Console.WriteLine("* Вариант #5                                                           *"); 
        Console.WriteLine("* Выполнил: Черкашин Максим Михайлович | ИИПб-24-1                     *"); 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* УСЛОВИЕ:                                                             *");
        Console.WriteLine("* Напишите программу, которая ищет среди целых чисел, принадлежащих    *");
        Console.WriteLine("* числовому отрезку сумму всех делителей                               *");
        Console.WriteLine("*                                                                      *");
        Console.WriteLine("************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                     *");
        Console.WriteLine("* Числовой отзерок [15, 22]                                            *");
        Console.WriteLine("************************************************************************"); 
 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *"); 
        Console.WriteLine("************************************************************************"); 
 
        DataService ds = new DataService();
        Console.WriteLine(ds.GetSumTheDivisors(15, 22)); 
    } 
} 
