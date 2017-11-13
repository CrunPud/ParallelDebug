using NUnit.Framework;
using System;
using NUnit.Framework.Interfaces;

namespace SolutionAttribute
{
    [AttributeUsage(AttributeTargets.Assembly)]
    public class SolutionLevelAttribute : Attribute, ITestAction
    {
        public ActionTargets Targets => throw new NotImplementedException();

        public void AfterTest(ITest test)
        {
            throw new NotImplementedException();
        }

        public void BeforeTest(ITest test)
        {
            Console.WriteLine("Running suite: " + test.Name);
        }
    }
}
