using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;
using System.IO;

namespace Tyuiu.FaizullinDR.Sprint6.Task5.V11.Lib
{
    public class DataService : ISprint6Task5V11
    {
        public double[] LoadFromDataFile(string path)
        {
            string[] strValue = File.ReadAllLines(path);
            double[] arr = new double[strValue.Length];
            for (int i = 0; i < strValue.Length; i++)
            {
                arr[i] = Convert.ToDouble(strValue[i]);
            }

            double[] res = arr.Where(i => i % 5 == 0).ToArray();
            return res;
        }
    }
}
