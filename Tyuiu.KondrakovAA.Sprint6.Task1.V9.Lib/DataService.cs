using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.KondrakovAA.Sprint6.Task1.V9.Lib
{
    public class DataService : ISprint6Task1V9
    {
        public double[] GetMassFunction(int start, int stop)
        {
            int len = (stop - start) + 1;
            double [] arr = new double[len];
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
                    y = 2 * x - 4 + (2 * x - 1)/(Math.Sin(x) + 1) ;

                    arr[count] = y;
                    count++;
                }

            }
            return arr;
        }
    }
}
