# Abstract Factory Pattern

**Category:** Creational

The Abstract Factory pattern provides an interface for creating families of related or dependent objects without specifying their concrete classes.

---

## Structure

- `IAbstractFactory` – Interface for creating abstract products.
- `ConcreteFactory1/2` – Implement the factory to create concrete products.
- `IProductA/B` – Interfaces for different types of products.
- `ConcreteProductA1/A2/B1/B2` – Concrete implementations of products.
- `Client` – Uses only interfaces declared by AbstractFactory and Product classes.

---

## Usage

```csharp
var factory1 = new ConcreteFactory1();
var client1 = new Client(factory1);
Console.WriteLine(client1.ExecuteBusinessLogic());

var factory2 = new ConcreteFactory2();
var client2 = new Client(factory2);
Console.WriteLine(client2.ExecuteBusinessLogic());
```

---

## When to Use

- When you need to create families of related products.
- When you want to ensure products from one family are used together.
- When you need to configure your application with different product families.