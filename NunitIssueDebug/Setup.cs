using System;
using System.Threading;
using NUnit.Framework;

namespace NunitIssueDebug
{
    [SetUpFixture]
    public class Setup
    {
        [SetUp]
        public void TestSetup()
        {
            Console.WriteLine("Setting up the test");
        }

        [TearDown]
        public void TearDown()
        {
            Thread.Sleep(500);
            Console.WriteLine("Tearing down the test");
        }
    }
}
