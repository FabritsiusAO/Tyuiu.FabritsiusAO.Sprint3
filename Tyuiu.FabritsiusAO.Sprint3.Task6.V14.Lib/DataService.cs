﻿using System.Reflection.Metadata.Ecma335;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.FabritsiusAO.Sprint3.Task6.V14.Lib
{
    public class DataService : ISprint3Task6V14
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            int count = 0;
            for (int i = startValue; i <= stopValue; i++)
            {
                for (int d = 6; d <= 16; d++)
                {
                    if (i % d == 0) { count++; }
                }
            }
            return count;
        }
    }
}
