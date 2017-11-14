using System;
using System.Threading;
using NUnit.Framework;

namespace NunitIssueDebug
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void WaitMilliseconds()
        {
            int sleepTime = 10000;

            DateTime start = DateTime.Now;

            Console.WriteLine("Starting at: " + DateTime.Now);

            Thread.Sleep(sleepTime);

            Console.WriteLine("Ending at: " + DateTime.Now);

            DateTime end = DateTime.Now;

            double runTime = (end - start).TotalMilliseconds;

            Assert.GreaterOrEqual(runTime, sleepTime, "Thread.Sleep does not work as expected");
        }
    }
}
