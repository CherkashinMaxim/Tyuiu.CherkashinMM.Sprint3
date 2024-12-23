using tyuiu.cources.programming.interfaces.Sprint3; 
 
namespace Tyuiu.CherkashinMM.Sprint3.Task5.V28.Lib;

public class DataService : ISprint3Task5V28
{
    public double GetSumSumSeries(int x, int startValue1, int startValue2, int stopValue1, int stopValue2)
    {
        double sum1 = 0;
        for (int i = startValue1; i <= stopValue1; i++)
        {
            double sum2 = 0;
            for (int k = startValue2; k <= stopValue2; k++)
            {
                sum2 += (Math.Pow(k, x) / Math.Sin(k));
            }
            sum1 += sum2;
        }
        return Math.Round(sum1, 3);
    }
} 
