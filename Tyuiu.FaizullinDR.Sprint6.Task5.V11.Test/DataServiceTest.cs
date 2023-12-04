using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.FaizullinDR.Sprint6.Task5.V11.Lib;

namespace Tyuiu.FaizullinDR.Sprint6.Task5.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1() 
        {
            string path = @"C:\DataSprint6\InPutFileTask5V11.txt";
            DataService ds = new DataService();
            double[] res = ds.LoadFromDataFile(path);
            double[] wait = { 10 };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
