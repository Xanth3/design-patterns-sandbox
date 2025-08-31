namespace DesignPatternsSandbox.Creational.AbstractFactory;

public interface IProductB
{
    string GetName();
    string InteractWith(IProductA productA);
}