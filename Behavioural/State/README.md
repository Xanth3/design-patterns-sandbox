# State Pattern

**Category:** Behavioral

The State pattern allows an object to alter its behavior when its internal state changes. The object will appear to change its class.

---

## Structure

- `IState` – Interface for state-specific behavior.
- `ConcreteStateA/B` – Concrete implementations of state behavior.
- `Context` – Maintains a reference to a state and delegates requests to it.

---

## Usage

```csharp
var context = new Context(new ConcreteStateA());
Console.WriteLine(context.Request()); // Output: State A handling request.

context.SetState(new ConcreteStateB());
Console.WriteLine(context.Request()); // Output: State B handling request.
```

---

## When to Use

- When an object’s behavior depends on its state and must change at runtime.
- To avoid large conditional statements for state-specific behavior.
