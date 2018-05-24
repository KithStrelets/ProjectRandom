using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectRandom.Models;
using ProjectRandom.Models.Database;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest
    {
        // ToDo: Test character building and choosing
        //       Test session creation
        //       Test session ending-saving
        //       Test session restore
        //       Test session flow
        //       Test active sessions caching module
        //       Test data fetching
        //       Test randomizer mechanism
        //       to be continued...


        [TestMethod]
        public void TestSingleInstanceOfMongoConnection()
        {
            Console.WriteLine("===Test the access to active connection===");
            Assert.IsNotNull(MongoConnection.GetInstance());
        }

        [TestMethod]
        public void TestMongoConnectionLoss()
        {
            Console.WriteLine("===Receiving null while connection is unavailable===");
            Console.WriteLine(MongoConnection.GetInstance() != null
                                  ? "\tConnection is available"
                                  : "\tConnection is UNAVAILABLE");
        }
    }
}