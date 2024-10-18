using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.FabritsiusAO.Sprint3.Task1.V17.Lib
{
    public class DataService : ISprint3Task1V17
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double P = 0;
            int k = startValue;
            while(k <= 4)
            {
                P = P + Math.Pow(2 / Math.Cos(value), k);
                k++;
            }
            return Math.Round(P,3);
        }
    }
}
