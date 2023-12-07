using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KarpovAA.Sprint6.Task5.V9.Lib;
using System.IO;

namespace Tyuiu.KarpovAA.Sprint6.Task5.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\karpo\source\repos\Tyuiu.KarpovAA.Sprint6\Tyuiu.KarpovAA.Sprint6.Task5.V9\bin\Debug\InPutFileTask5V9.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
