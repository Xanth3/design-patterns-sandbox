using Xunit;
using Design.Patterns.Sandbox.Behavioural.Strategy;

namespace Design.Patterns.Sandbox.Tests
{
    public class StrategyTests
    {
        [Fact]
        public void Strategy_CompressData_UsingZipStrategy()
        {
            var context = new CompressionContext(new ZipCompression());
            var result = context.CompressData("example");
            Assert.Equal("ZIP: example", result);
        }

        [Fact]
        public void Strategy_CompressData_UsingRarStrategy()
        {
            var context = new CompressionContext(new RarCompression());
            var result = context.CompressData("example");
            Assert.Equal("RAR: example", result);
        }
    }
}
