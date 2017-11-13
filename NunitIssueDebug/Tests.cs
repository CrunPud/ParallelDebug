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

            Thread.Sleep(sleepTime);

            int runTime = (DateTime.Now - start).Milliseconds;

            Assert.GreaterOrEqual(runTime, sleepTime, "Thread.Sleep does not work as expected");
        }
    }
}
