using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.KorneevaEA.Sprint2.Task7.V11.Lib
{
    public class DataService : ISprint2Task7V11
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool res;

            if ((Math.Pow(x, 2) + Math.Pow(y, 2) == 1))
            {
                return true;
            }
            if (((x <= 0 && x >= -1) && (y >= 1 && y <= 1)) || ((x >= 0 && x <= 0.5) && (y >= 0 && y <= 1)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
