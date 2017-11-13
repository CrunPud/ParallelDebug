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
            int sleepTime = 15;

            DateTime start = DateTime.Now;

            Thread.Sleep(sleepTime * 1000);

            int runTime = (DateTime.Now - start).Seconds;

            Assert.GreaterOrEqual(runTime, sleepTime, "Thread.Sleep does not work as expected");
        }
    }
}
