﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.SizikovSS.Sprint2.Task0.V23.Lib
{
    public class DataService : ISprint2Task0V23
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] res = new bool[6];
            res[0] = x != y;
            res[1] = x == y;
            res[2] = x < y;
            res[3] = y > x;
            res[4] = y <= x;
            res[5] = y >= x;

            return res;
        }
    }
}
