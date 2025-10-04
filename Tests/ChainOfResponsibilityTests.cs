using Design.Patterns.Sandbox.Behavioural.ChainOfResponsibility;
using Xunit;

namespace Design.Patterns.Sandbox.Tests
{
    public class ChainOfResponsibilityTests
    {
        [Fact]
        public void HandlerA_Handles_A()
        {
            var handlerA = new ConcreteHandlerA();
            var handlerB = new ConcreteHandlerB();
            handlerA.SetNext(handlerB);
            Assert.Equal("Handled by A", handlerA.Handle("A"));
        }

        [Fact]
        public void HandlerB_Handles_B()
        {
            var handlerA = new ConcreteHandlerA();
            var handlerB = new ConcreteHandlerB();
            handlerA.SetNext(handlerB);
            Assert.Equal("Handled by B", handlerA.Handle("B"));
        }

        [Fact]
        public void Chain_Returns_NotHandled_For_Unknown()
        {
            var handlerA = new ConcreteHandlerA();
            var handlerB = new ConcreteHandlerB();
            handlerA.SetNext(handlerB);
            Assert.Equal("Not handled", handlerA.Handle("C"));
        }
    }
}
