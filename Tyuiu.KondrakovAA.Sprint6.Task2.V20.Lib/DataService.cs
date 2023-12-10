using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.KondrakovAA.Sprint6.Task2.V20.Lib
{
    public class DataService : ISprint6Task2V20
    {
        public double[] GetMassFunction(int start, int stop)
        {
            int len = (stop - start) + 1;
            double[] arr = new double[len];
            double y;
            int count = 0;
            for (int x = start; x <= stop; x++)
            {
                if ((Math.Sin(x) + 1) == 0)
                {
                    arr[count] = 0;
                    count++;
                    continue;
                }
                else
                {
                    y = Math.Round((Math.Sin(x)/(x + 1.2) - Math.Sin(x) * 2 - 2 * x), 2);

                    arr[count] = y;
                    count++;
                }

            }
            return arr;
        }
    }
}
