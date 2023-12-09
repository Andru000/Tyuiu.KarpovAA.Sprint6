using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KarpovAA.Sprint6.Task6.V4.Lib;
using System.IO;

namespace Tyuiu.KarpovAA.Sprint6.Task6.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\DataSprint6\InPutFileTask6V4.txt";
            DataService ds = new DataService();
            string res = ds.CollectTextFromFile(path);
            string wait = "SnBC nnndrM RbvnKtNW ";
            Assert.AreEqual(wait, res);
        }
    }
}
