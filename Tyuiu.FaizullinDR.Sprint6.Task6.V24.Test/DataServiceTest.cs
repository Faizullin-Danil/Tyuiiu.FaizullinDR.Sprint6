using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.FaizullinDR.Sprint6.Task6.V24.Lib;

namespace Tyuiu.FaizullinDR.Sprint6.Task6.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\DataSprint6\InPutFileTask6V24.txt";
            DataService ds = new DataService();
            string wait = "EovFJVudRgdWKwQBrOMEwyq";
            string res = ds.CollectTextFromFile(path);
            Assert.AreEqual(res, wait);
        }
    }
}
