using System;
using NUnit.Framework;

/* Requires having no namespace */
[SetUpFixture]
public class AssemblySetup
{
    [OneTimeSetUp]
    public void SetupOnce()
    {
        Console.WriteLine("Assembly level setup");
    }

    [OneTimeTearDown]
    public void TearDownOnce()
    {
        Console.WriteLine("Assembly level teardown");
    }
}