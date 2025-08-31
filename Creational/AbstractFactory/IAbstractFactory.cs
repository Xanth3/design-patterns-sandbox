namespace DesignPatternsSandbox.Creational.AbstractFactory;

public interface IAbstractFactory
{
    IProductA CreateProductA();
    IProductB CreateProductB();
}