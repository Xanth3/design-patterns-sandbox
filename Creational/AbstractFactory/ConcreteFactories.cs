namespace DesignPatternsSandbox.Creational.AbstractFactory;

public class ConcreteFactory1 : IAbstractFactory
{
    public IProductA CreateProductA() => new ConcreteProductA1();
    
    public IProductB CreateProductB() => new ConcreteProductB1();
}

public class ConcreteFactory2 : IAbstractFactory
{
    public IProductA CreateProductA() => new ConcreteProductA2();
    
    public IProductB CreateProductB() => new ConcreteProductB2();
}