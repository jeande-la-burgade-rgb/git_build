using Xunit;
using git_build.Logic;

namespace git_build.Tests
{
    public class NumServiceTests
    {
        [Fact]
        public void GetProcessedNumber_ShouldReturn132()
        {
            var service = new NumService();

            var result = service.GetProcessedNumber();

            Assert.Equal(132, result);
        }
    }
}
