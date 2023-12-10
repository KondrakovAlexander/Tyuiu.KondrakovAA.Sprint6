using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.KondrakovAA.Sprint6.Task4.V26.Lib
{
    public class DataService : ISprint6Task4V26
    {
        public double[] GetMassFunction(int start, int stop) 
        {
            double[] arr = new double[11];
            double y;
            int count = 0;
            for (int x = start; x < stop; x++)
            {
                if ((2 * x - 0.5) == 0)
                {
                    arr[count] = 0;
                    count++;
                    continue;
                }
                else
                {
                    y = Math.Round((5 - 3 * x + (1 + Math.Sin(x))/(2 * x - 0.5)), 2);
                    arr[count] = y;
                    count++;
                }

            }
            return arr;
        }
    }
}
