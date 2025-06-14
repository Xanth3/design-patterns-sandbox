using Xunit;
using Design.Patterns.Sandbox.Creational.Singleton;

namespace Design.Patterns.Sandbox.Tests
{
    public class SingletonTests
    {
        [Fact]
        public void Singleton_Should_Return_Same_Instance()
        {
            var instance1 = Singleton.Instance;
            var instance2 = Singleton.Instance;

            Assert.Same(instance1, instance2);
            Assert.Equal("I am a Singleton instance.", instance1.GetMessage());
        }
    }
}