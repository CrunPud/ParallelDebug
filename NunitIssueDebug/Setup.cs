using System;
using System.Threading;
using NUnit.Framework;

namespace NunitIssueDebug
{
    [SetUpFixture]
    public class Setup
    {
        [OneTimeSetUp]
        public void TestSetup()
        {
            Console.WriteLine("Setting up the test");
        }

        [OneTimeTearDown]
        public void TearDown()
        {
            Thread.Sleep(500);
            Console.WriteLine("Tearing down the test");
        }
    }
}
