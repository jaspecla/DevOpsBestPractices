using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DevOpsBestPractices.Tests
{
  [TestClass]
  public class TrivialTest
  {
    [TestMethod]
    public void Test_Always_Passes()
    {
      Assert.IsTrue(true);
    }
  }
}
