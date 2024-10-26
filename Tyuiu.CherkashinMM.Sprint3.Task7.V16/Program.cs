using Tyuiu.CherkashinMM.Sprint3.Task7.V16.Lib; 
 
namespace Tyuiu.BarbashinAV.Sprint3.Task7.V16; 
 
class Program 
{ 
    static void Main(string[] args) 
    { 
        Console.Title = "Спринт #3 | Выполнил: Черкашин М. М. | ИИПб-24-1"; 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* Спринт #3                                                            *"); 
        Console.WriteLine("* Тема:                                                                *"); 
        Console.WriteLine("* Задание #7                                                           *"); 
        Console.WriteLine("* Вариант #16                                                          *"); 
        Console.WriteLine("* Выполнил: Черкашин Максим Михайлович | ИИПб-24-1                     *"); 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* УСЛОВИЕ:                                                             *");
        Console.WriteLine("* Вывести таблицу значений функции:                                    *");
        Console.WriteLine("*                                                                      *");
        Console.WriteLine("*          cos(x)                                                      *");
        Console.WriteLine("* F(x) = ---------- + sin(x) * 8x + 2                                  *");
        Console.WriteLine("*         x - 0,4                                                      *");
        Console.WriteLine("*                                                                      *");
        Console.WriteLine("*                                                                      *");
        Console.WriteLine("************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                     *");
        Console.WriteLine("* Диапазон x: [-5; 5]                                                  *");
        Console.WriteLine("* Шаг: 1                                                               *");
        Console.WriteLine("************************************************************************"); 
 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *");
        Console.WriteLine("************************************************************************");

        Console.WriteLine("+----------+----------+");
        Console.WriteLine("|    x     |   f(x)   |");
        Console.WriteLine("+----------+----------+");

        DataService ds = new DataService();
        double[] res = ds.GetMassFunction(-5, 5);
        for (int i = 0; i < res.Length; i++)
        {
             Console.WriteLine($"|  {-5+i}" + new string(' ', 8-Convert.ToString(-5+i).Length) + $"|  {res[i]}" + new string(' ', 8-Convert.ToString(res[i]).Length) + "|");
        }
    } 
} 
