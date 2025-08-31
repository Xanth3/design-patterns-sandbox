using Xunit;
using DesignPatternsSandbox.Creational.AbstractFactory;

namespace Design.Patterns.Sandbox.Tests
{
    public class AbstractFactoryTests
    {
        [Fact]
        public void ConcreteFactory1_Should_Create_Family1_Products()
        {
            var factory = new ConcreteFactory1();
            var client = new Client(factory);
            
            string result = client.ExecuteBusinessLogic();
            
            Assert.Equal("Product B1 interacting with Product A1", result);
        }

        [Fact]
        public void ConcreteFactory2_Should_Create_Family2_Products()
        {
            var factory = new ConcreteFactory2();
            var client = new Client(factory);
            
            string result = client.ExecuteBusinessLogic();
            
            Assert.Equal("Product B2 collaborating with Product A2", result);
        }

        [Fact]
        public void ProductA1_Should_Return_Correct_Name()
        {
            var product = new ConcreteProductA1();
            
            Assert.Equal("Product A1", product.GetName());
        }

        [Fact]
        public void ProductA2_Should_Return_Correct_Name()
        {
            var product = new ConcreteProductA2();
            
            Assert.Equal("Product A2", product.GetName());
        }

        [Fact]
        public void ProductB1_Should_Interact_With_ProductA()
        {
            var productA = new ConcreteProductA1();
            var productB = new ConcreteProductB1();
            
            string result = productB.InteractWith(productA);
            
            Assert.Equal("Product B1 interacting with Product A1", result);
        }

        [Fact]
        public void ProductB2_Should_Collaborate_With_ProductA()
        {
            var productA = new ConcreteProductA2();
            var productB = new ConcreteProductB2();
            
            string result = productB.InteractWith(productA);
            
            Assert.Equal("Product B2 collaborating with Product A2", result);
        }
    }
}