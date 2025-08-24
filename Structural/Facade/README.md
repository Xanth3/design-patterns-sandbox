# Facade Pattern

**Category:** Structural

The Facade pattern provides a simplified interface to a complex subsystem, making it easier for clients to interact with the system.

---

## Structure

- `Facade` – Provides a simple interface to the subsystem.
- `SubsystemA/B` – Classes that implement subsystem functionality.

---

## Usage

```csharp
var facade = new Facade(new SubsystemA(), new SubsystemB());
Console.WriteLine(facade.Operation());
// Output: Facade: SubsystemA: OperationA | SubsystemB: OperationB
```

---

## When to Use

- When you want to provide a simple interface to a complex subsystem.
- To decouple clients from subsystem implementation details.
