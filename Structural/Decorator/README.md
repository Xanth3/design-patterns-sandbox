# Decorator Pattern

**Category:** Structural

The Decorator pattern attaches additional responsibilities to an object dynamically. Decorators provide a flexible alternative to subclassing for extending functionality.

---

## Structure

- `IComponent` – The common interface for objects and decorators.
- `ConcreteComponent` – The base object to be decorated.
- `Decorator` – Abstract base class for decorators.
- `ConcreteDecoratorA/B` – Concrete decorators that add behavior.

---

## Usage

```csharp
IComponent component = new ConcreteComponent();
IComponent decorated = new ConcreteDecoratorA(component);
Console.WriteLine(decorated.Operation()); 

IComponent multiDecorated = new ConcreteDecoratorB(decorated);
Console.WriteLine(multiDecorated.Operation()); 
```

---

## When to Use

- Adding responsibilities to individual objects, not entire classes.
- Extending behavior without modifying existing code.