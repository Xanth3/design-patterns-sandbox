namespace DesignPatterns.Sandbox.Creational.FactoryMethod
{
    public class Truck : IProduct
    {
        public string Transport() => "Shipped by land (Truck)";
    }

    public class Ship : IProduct
    {
        public string Transport() => "Shipped by sea (Ship)";
    }
}
