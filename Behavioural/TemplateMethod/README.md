# Template Method Pattern

**Category:** Behavioral

The Template Method pattern defines the skeleton of an algorithm in a base class, allowing subclasses to override specific steps without changing the overall structure.

---

## Structure

- `IProcess` – Interface for running the process.
- `AbstractProcess` – Base class with the template method and default steps.
- `ConcreteProcessA/B` – Subclasses that implement the variable steps.

---

## Usage

```csharp
IProcess processA = new ConcreteProcessA();
Console.WriteLine(processA.Run()); // Output: Initial Step -> Core Step A -> Final Step

IProcess processB = new ConcreteProcessB();
Console.WriteLine(processB.Run()); // Output: Initial Step -> Core Step B -> Final Step
```

---

## When to Use

- When multiple classes share the same algorithm structure but differ in specific steps.
- To avoid code duplication and promote reuse of common logic.
