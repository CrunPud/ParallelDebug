using NUnit.Framework;

/* Requires having no namespace */
[SetUpFixture]
public class AssemblySetup
{
    [OneTimeSetUp]
    public void SetupOnce()
    {
    }

    [OneTimeTearDown]
    public void TearDownOnce()
    {
    }
}