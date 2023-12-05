using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;
using System.IO;

namespace Tyuiu.FaizullinDR.Sprint6.Task6.V24.Lib
{
    public class DataService : ISprint6Task6V24
    {
        public string CollectTextFromFile(string path)
        {
            string[] strPath = File.ReadAllLines(path);
            string strRes = "";
            for (int i = 0; i < strPath.Length; i++)
            {
                string[] strFirstWord = strPath[i].Split(' ');
                strRes += strFirstWord[0];
            }
            return strRes;
        }
    }
}
