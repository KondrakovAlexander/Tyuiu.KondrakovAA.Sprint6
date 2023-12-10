using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.KondrakovAA.Sprint6.Task7.V30.Lib
{
    public class DataService : ISprint6Task7V30
    {
        public int[,] GetMatrix(int[,] matrix)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;

            for (int i = 0; i <= 0; i++)
            {
                for (int j = 0; j < columns; j++) 
                {
                    if (matrix[j,i] != 4)
                    {
                        matrix[j, i] = 8;
                    }
                }
            }

            return matrix;
        }
    }
}
