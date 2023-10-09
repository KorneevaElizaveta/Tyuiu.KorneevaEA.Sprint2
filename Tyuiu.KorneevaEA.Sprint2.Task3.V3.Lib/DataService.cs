﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.KorneevaEA.Sprint2.Task3.V30.Lib
{
    public class DataService : ISprint2Task3V30
    {
        public double Calculate(double x)
        {
            if (x > 1)
            {
                return Math.Round(x * Math.Pow(((x + 1) / (x - 1)), x), 3);
            }

            if (x == 0)
            {
                return Math.Round(((Math.Pow(x, 4) - Math.Cos(Math.Pow(x, 5)) + 3) / (Math.Pow(x, 2) - Math.Sin(Math.Pow(x, 2)) + 12)), 3);
            }

            if (x > -7 && x < 0)
            {
                return Math.Round((Math.Pow((1 + (Math.Pow(x + 3, 0.5)) / (Math.Pow(x, 2))), x)), 3);
            }

            else
            {
                return Math.Round((Math.Pow(x, 2) + 10 * x - 1 / x), 3);
            }
        }
    }
}