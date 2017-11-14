using System;
using System.Threading;
using NUnit.Framework;

namespace NunitIssueDebug
{
    [TestFixture]
    public class MoreTests
    {
        [Test]
        public void WaitSeconds()
        {
            int sleepTime = 10;

            DateTime start = DateTime.Now;

            Thread.Sleep(sleepTime * 1000);

            DateTime end = DateTime.Now;

            double runTime = (end - start).TotalSeconds;

            Assert.GreaterOrEqual(runTime, sleepTime, "Thread.Sleep does not work as expected");
        }
    }
}
