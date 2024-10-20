﻿using System.ComponentModel.Design;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.FabritsiusAO.Sprint3.Task4.V19.Lib
{
    public class DataService : ISprint3Task4V19
    {
        public double Calculate(int startValue, int stopValue)
        {
            double res = 1;
            for (int x = startValue; x <= stopValue; x++)
            {
                if (x == 0)
                {
                    break;
                }

                else
                {
                    double y = x / (Math.Cos(x) + x) + 0.5;
                    res = res * y;
                }
            }
            return Math.Round(res, 3);
        }
    }
}
