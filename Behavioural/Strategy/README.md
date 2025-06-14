# Strategy Pattern

**Category:** Behavioural

The Strategy pattern defines a family of algorithms, encapsulates each one, and makes them interchangeable. Strategy lets the algorithm vary independently from clients that use it.

---

## Structure

- `IStrategy` – Interface for algorithms.
- `ConcreteStrategyA/B` – Concrete implementations of the algorithm.
- `Context` – Maintains a reference to a strategy and delegates execution.

---

## Usage

```csharp
var context = new CompressionContext(new ZipCompression());
Console.WriteLine(context.CompressData("myfile"));
```

---

## When to Use

- When you need to switch between different algorithms at runtime.
- To avoid using conditional statements for selecting behavior.