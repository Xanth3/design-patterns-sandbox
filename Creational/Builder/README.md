# Builder Pattern

**Category:** Creational

The Builder pattern separates the construction of a complex object from its representation, allowing the same construction process to create different representations.

---

## Structure

- `IBuilder` – Interface for building parts of a product.
- `ConcreteBuilder` – Implements building steps and assembles the product.
- `Director` – Orchestrates the building process (optional).
- `Product` – The complex object being built.

---

## Usage

```csharp
var builder = new ConcreteBuilder();
var director = new Director();
director.Construct(builder);
Product product = builder.GetProduct();
```

---

## When to Use

- When constructing complex objects step by step.
- When different representations of an object are needed.
