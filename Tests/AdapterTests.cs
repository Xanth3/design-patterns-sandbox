using Xunit;
using Design.Patterns.Sandbox.Structural.Adapter;

namespace Design.Patterns.Sandbox.Tests
{
    public class AdapterTests
    {
        [Fact]
        public void Adapter_Returns_Adaptee_SpecificRequest()
        {
            var adaptee = new Adaptee();
            ITarget adapter = new Adapter(adaptee);

            Assert.Equal("Specific request from Adaptee", adapter.GetRequest());
        }
    }
}