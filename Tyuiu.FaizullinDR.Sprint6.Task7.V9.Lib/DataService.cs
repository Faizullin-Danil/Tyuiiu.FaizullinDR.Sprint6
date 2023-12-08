using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;
using System.IO;

namespace Tyuiu.FaizullinDR.Sprint6.Task7.V9.Lib
{
    public class DataService : ISprint6Task7V9
    {
        public int[,] GetMatrix(string path)
        {
            string[] str = File.ReadAllLines(path);

            int rows = str[0].Split(';').Length;
            int columns = str.Length;

            int[,] matrix = new int[rows, columns];

            for (int i = 0; i < str.Length; i++)
            {
                string strIndexI = str[i];
                string[] strArr = strIndexI.Split(';');
                for (int c = 0; c < str.Length; c++)
                {
                    matrix[i, c] = Convert.ToInt32(strArr[c]);
                }
            }
            return matrix;
        }
        
    }
}
