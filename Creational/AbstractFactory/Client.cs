namespace DesignPatternsSandbox.Creational.AbstractFactory;

public class Client
{
    private readonly IProductA _productA;
    private readonly IProductB _productB;

    public Client(IAbstractFactory factory)
    {
        _productA = factory.CreateProductA();
        _productB = factory.CreateProductB();
    }

    public string ExecuteBusinessLogic()
    {
        return _productB.InteractWith(_productA);
    }
}