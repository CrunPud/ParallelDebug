using NUnit.Framework;
using System;
using NUnit.Framework.Interfaces;

namespace SolutionAttribute
{
    [AttributeUsage(AttributeTargets.Assembly)]
    public class SolutionLevelAttribute : Attribute, ITestAction
    {
        public ActionTargets Targets => ActionTargets.Suite;

        public void AfterTest(ITest test)
        {
            Console.WriteLine("Running Solution attribute for: " + test.Name);
        }

        public void BeforeTest(ITest test)
        {
            Console.WriteLine("Running Solution attribute for: " + test.Name);
        }
    }
}
