using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.KondrakovAA.Sprint6.Task3.V14.Lib
{
    public class DataService : ISprint6Task3V14
    {
        public int[,] Calculate(int[,] x ) 
        { 
            for(int i = 0; i < 5; i++)
            {
                if(x[1,i] % 2 == 0)
                {
                    x[1, i] = 0;
                }
            }
            return x;
        }
    }
}
