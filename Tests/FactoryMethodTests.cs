using Xunit;
using Design.Patterns.Sandbox.Creational.FactoryMethod;

namespace Design.Patterns.Sandbox.Tests
{
    public class FactoryMethodTests
    {
        [Fact]
        public void RoadLogistics_Should_Ship_By_Truck()
        {
            Logistics logistics = new RoadLogistics();
            string result = logistics.Deliver();
            Assert.Equal("Shipped by land (Truck)", result);
        }

        [Fact]
        public void SeaLogistics_Should_Ship_By_Ship()
        {
            Logistics logistics = new SeaLogistics();
            string result = logistics.Deliver();
            Assert.Equal("Shipped by sea (Ship)", result);
        }
    }
}
