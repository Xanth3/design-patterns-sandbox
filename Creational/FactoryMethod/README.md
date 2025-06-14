# Factory Method Pattern

**Category:** Creational

The Factory Method pattern defines an interface for creating an object, but lets subclasses alter the type of objects that will be created.

---

## Structure

- `Product` – The interface or abstract class for products.
- `ConcreteProductA/B` – Concrete implementations of `Product`.
- `Creator` – Declares the factory method.
- `ConcreteCreatorA/B` – Implement the factory method to return a specific product.

---

## Usage

```csharp
Logistics logistics = new RoadLogistics();
Console.WriteLine(logistics.Deliver()); // Shipped by land (Truck)
```

---

## When to Use

- When a class can't anticipate the class of objects it must create.
- To delegate responsibility of instantiation to subclasses.