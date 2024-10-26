using tyuiu.cources.programming.interfaces.Sprint3; 
 
namespace Tyuiu.CherkashinMM.Sprint3.Task2.V2.Lib;

public class DataService : ISprint3Task2V2
{
    public double GetMultiplySeries(int startValue, int stopValue)
    {
        double result = 1;
        do
        {
            result *= Math.Sin(0.1) + startValue;
            startValue++;
        } while (startValue <= stopValue);
        return Math.Round(result, 3);
    }
}