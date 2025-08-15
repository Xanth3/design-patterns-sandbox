using Design.Patterns.Sandbox.Behavioural.State;
using Xunit;

namespace Design.Patterns.Sandbox.Tests
{
    public class StateTests
    {
        [Fact]
        public void Context_Uses_Initial_State()
        {
            var context = new Context(new ConcreteStateA());
            Assert.Equal("State A handling request.", context.Request());
        }

        [Fact]
        public void Context_Changes_State_At_Runtime()
        {
            var context = new Context(new ConcreteStateA());
            context.SetState(new ConcreteStateB());
            Assert.Equal("State B handling request.", context.Request());
        }
    }
}
