using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectRandom.Models;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        //private MongoConnection connection = new MongoConnection();

        [TestMethod]
        public void TestMethod1()
        {
            var test = MongoConnection.GetInstance();
            Console.WriteLine("===Creating second instance===");
            test = null;
            //var test2 = MongoConnection.GetInstance() as MongoConnection;
            test = MongoConnection.GetInstance();
            //Console.WriteLine(test2.GetDatabase());
            Console.WriteLine(test.ToString());
           // Console.WriteLine(test2.ToString());
            Assert.IsNotNull(test);
        }
    }
}
