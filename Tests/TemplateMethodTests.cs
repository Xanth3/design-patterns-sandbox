using Design.Patterns.Sandbox.Behavioural.TemplateMethod;
using Xunit;

namespace Design.Patterns.Sandbox.Tests
{
    public class TemplateMethodTests
    {
        [Fact]
        public void ConcreteProcessA_Returns_CorrectSteps()
        {
            IProcess process = new ConcreteProcessA();
            Assert.Equal("Initial Step -> Core Step A -> Final Step", process.Run());
        }

        [Fact]
        public void ConcreteProcessB_Returns_CorrectSteps()
        {
            IProcess process = new ConcreteProcessB();
            Assert.Equal("Initial Step -> Core Step B -> Final Step", process.Run());
        }
    }
}
