using Tyuiu.CherkashinMM.Sprint3.Task3.V16.Lib; 
 
namespace Tyuiu.BarbashinAV.Sprint3.Task3.V16; 
 
class Program 
{ 
    static void Main(string[] args) 
    { 
        Console.Title = "Спринт #3 | Выполнил: Черкашин М. М. | ИИПб-24-1"; 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* Спринт #3                                                            *"); 
        Console.WriteLine("* Тема: Оператор цикла foreach                                         *"); 
        Console.WriteLine("* Задание #3                                                           *"); 
        Console.WriteLine("* Вариант #16                                                          *"); 
        Console.WriteLine("* Выполнил: Черкашин Максим Михайлович | ИИПб-24-1                     *"); 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* УСЛОВИЕ:                                                             *");
        Console.WriteLine("* Используя цикл foreach подсчитать количество букв “c” в строке       *");
        Console.WriteLine("*                                                                      *");
        Console.WriteLine("************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                     *");
        Console.WriteLine("* ice nice ice creamcc                                                 *");
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *"); 
        Console.WriteLine("************************************************************************"); 
    
        DataService ds = new DataService();
        Console.WriteLine(ds.GetCharCount("ice nice ice creamcc", 'c')); 
    } 
} 
