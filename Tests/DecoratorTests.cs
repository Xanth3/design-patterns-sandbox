using Design.Patterns.Sandbox.Structural.Decorator;
using Xunit;

namespace Design.Patterns.Sandbox.Tests
{
    public class DecoratorTests
    {
        [Fact]
        public void ConcreteComponent_Returns_BaseString()
        {
            IComponent component = new ConcreteComponent();
            Assert.Equal("ConcreteComponent", component.Operation());
        }

        [Fact]
        public void ConcreteDecoratorA_Wraps_Component()
        {
            IComponent component = new ConcreteDecoratorA(new ConcreteComponent());
            Assert.Equal("DecoratorA(ConcreteComponent)", component.Operation());
        }

        [Fact]
        public void ConcreteDecoratorB_Wraps_Component()
        {
            IComponent component = new ConcreteDecoratorB(new ConcreteComponent());
            Assert.Equal("DecoratorB(ConcreteComponent)", component.Operation());
        }

        [Fact]
        public void MultipleDecorators_NestCorrectly()
        {
            IComponent component = new ConcreteDecoratorB(
                new ConcreteDecoratorA(
                    new ConcreteComponent()));
            Assert.Equal("DecoratorB(DecoratorA(ConcreteComponent))", component.Operation());
        }
    }
}