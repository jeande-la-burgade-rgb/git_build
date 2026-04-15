using Microsoft.VisualStudio.TestTools.UnitTesting;
using git_build.Logic;

namespace git_build.Tests
{
    [TestClass]
    public class NumServiceTests
    {
        [TestMethod]
        public void GetProcessedNumber_ShouldReturn132()
        {
            var service = new NumService();

            var result = service.GetProcessedNumber();

            Assert.AreEqual(132, result);
        }
    }
}
