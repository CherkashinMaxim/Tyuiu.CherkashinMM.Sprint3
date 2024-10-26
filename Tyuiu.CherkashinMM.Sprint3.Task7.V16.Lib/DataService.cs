using tyuiu.cources.programming.interfaces.Sprint3; 
 
namespace Tyuiu.CherkashinMM.Sprint3.Task7.V16.Lib;

public class DataService : ISprint3Task7V16
{
    public double[] GetMassFunction(int startValue, int stopValue)
    {
        double[] res = new double[11];
        int cnt = 0;
        for (int x = startValue; x <= stopValue; x++)
        {
            double temp = Math.Round((Math.Cos(x)/(x - 0.4)) + Math.Sin(x) * 8 * x + 2, 2);
            res[cnt] = temp;
            cnt++;
        }
        return res;
    }
} 
