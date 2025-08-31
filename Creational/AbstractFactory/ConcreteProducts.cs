namespace DesignPatternsSandbox.Creational.AbstractFactory;

public class ConcreteProductA1 : IProductA
{
    public string GetName() => "Product A1";
}

public class ConcreteProductA2 : IProductA
{
    public string GetName() => "Product A2";
}

public class ConcreteProductB1 : IProductB
{
    public string GetName() => "Product B1";
    
    public string InteractWith(IProductA productA) => $"{GetName()} interacting with {productA.GetName()}";
}

public class ConcreteProductB2 : IProductB
{
    public string GetName() => "Product B2";
    
    public string InteractWith(IProductA productA) => $"{GetName()} collaborating with {productA.GetName()}";
}