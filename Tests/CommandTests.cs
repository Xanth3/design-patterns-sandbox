using Design.Patterns.Sandbox.Behavioural.Command;
using Xunit;

namespace Design.Patterns.Sandbox.Tests
{
    public class CommandTests
    {
        [Fact]
        public void Invoker_Executes_Command_And_Performs_Action()
        {
            var receiver = new Receiver();
            ICommand command = new ConcreteCommand(receiver);
            var invoker = new Invoker();
            invoker.SetCommand(command);
            invoker.ExecuteCommand();

            Assert.Equal("Action has been performed", receiver.ActionPerformed);
        }
    }
}
