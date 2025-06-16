namespace Design.Patterns.Sandbox.Creational.FactoryMethod
{
    public abstract class Logistics
    {
        public string Deliver()
        {
            var product = CreateTransport();
            return product.Transport();
        }

        protected abstract IProduct CreateTransport();
    }

    public class RoadLogistics : Logistics
    {
        protected override IProduct CreateTransport() => new Truck();
    }

    public class SeaLogistics : Logistics
    {
        protected override IProduct CreateTransport() => new Ship();
    }
}
