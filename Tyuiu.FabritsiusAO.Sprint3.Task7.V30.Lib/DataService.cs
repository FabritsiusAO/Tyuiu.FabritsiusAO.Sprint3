using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.FabritsiusAO.Sprint3.Task7.V30.Lib
{
    public class DataService : ISprint3Task7V30
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] res; int len = (stopValue - startValue) + 1; res = new double[len];
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                if (Math.Sin(x) + 2 == 0)
                {
                    res[count] = 0;
                    count++;
                }
                else
                {
                    double y = Math.Round((5 * x + 2.5) / (Math.Sin(x) + 2) + 2 * x + 2,2);
                    res[count] = y;
                    count++;
                }
            }
            return res;
        }
    }
}
