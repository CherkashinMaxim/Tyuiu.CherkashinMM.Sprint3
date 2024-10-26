using Tyuiu.CherkashinMM.Sprint3.Task4.V6.Lib; 
 
namespace Tyuiu.BarbashinAV.Sprint3.Task4.V6; 
 
class Program 
{ 
    static void Main(string[] args) 
    { 
        Console.Title = "Спринт #3 | Выполнил: Черкашин М. М. | ИИПб-24-1"; 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* Спринт #3                                                            *"); 
        Console.WriteLine("* Тема:                                                                *"); 
        Console.WriteLine("* Задание #4                                                           *"); 
        Console.WriteLine("* Вариант #6                                                           *"); 
        Console.WriteLine("* Выполнил: Черкашин Максим Михайлович | ИИПб-24-1                     *"); 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* УСЛОВИЕ:                                                             *");
        Console.WriteLine("* На отрезке, где x принимает значения от -5 до 5, вычислить значение  *");
        Console.WriteLine("* функции y=x/(cos(x)-sin(x)). При х = 0 прервать цикл.                *");
        Console.WriteLine("* Полученные значения суммировать.                                     *");
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                     *"); 
        Console.WriteLine("************************************************************************"); 
 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *"); 
        Console.WriteLine("************************************************************************"); 
 
        DataService ds = new DataService();
        Console.WriteLine(ds.Calculate(-5, 5)); 
    } 
} 
