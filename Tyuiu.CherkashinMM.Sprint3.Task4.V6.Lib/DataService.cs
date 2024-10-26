using tyuiu.cources.programming.interfaces.Sprint3; 
 
namespace Tyuiu.CherkashinMM.Sprint3.Task4.V6.Lib;

public class DataService : ISprint3Task4V6
{
    public double Calculate(int startValue, int stopValue)
    {
        double sum = 0.0;
        for (int i = startValue; i <= stopValue; i++)
        {
            if(startValue == 0)
            {
                break;
            }
            sum += startValue / (Math.Cos(startValue) - Math.Sin(startValue));
        }
        return Math.Round(sum, 3);
    }
} 
