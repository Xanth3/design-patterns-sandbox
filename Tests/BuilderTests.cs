using Design.Patterns.Sandbox.Creational.Builder;
using Xunit;

namespace Design.Patterns.Sandbox.Tests
{
    public class BuilderTests
    {
        [Fact]
        public void Director_Constructs_Product_Correctly()
        {
            var builder = new ConcreteBuilder();
            var director = new Director();
            director.Construct(builder);
            var product = builder.GetProduct();

            Assert.Equal("Alpha", product.PartA);
            Assert.Equal(42, product.PartB);
        }

        [Fact]
        public void Builder_Can_Build_Custom_Product()
        {
            var builder = new ConcreteBuilder();
            builder.SetPartA("Custom");
            builder.SetPartB(99);
            var product = builder.GetProduct();

            Assert.Equal("Custom", product.PartA);
            Assert.Equal(99, product.PartB);
        }
    }
}
