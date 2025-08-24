using Design.Patterns.Sandbox.Structural.Facade;
using Xunit;

namespace Design.Patterns.Sandbox.Tests
{
    public class FacadeTests
    {
        [Fact]
        public void Facade_Operation_Returns_Combined_Result()
        {
            var facade = new Facade(new SubsystemA(), new SubsystemB());
            var expected = "Facade: SubsystemA: OperationA | SubsystemB: OperationB";
            Assert.Equal(expected, facade.Operation());
        }
    }
}
