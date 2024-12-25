using System.IO;
using Tyuiu.ShanginAA.Sprint5.Task0.V19.Lib;

namespace Tyuiu.ShanginAA.Sprint5.Task0.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\msi\source\repos\Tyuiu.ShanginAA.Sprint5\Tyuiu.ShanginAA.Sprint5.Task0.V19\bin\Debug\OutPutFileTask0.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}