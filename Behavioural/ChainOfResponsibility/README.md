# Chain of Responsibility Pattern

**Category:** Behavioral

The Chain of Responsibility pattern lets you pass requests along a chain of handlers. Each handler decides either to process the request or to pass it to the next handler in the chain.

---

## Structure

- `Handler` – Abstract base class for handling requests and linking to the next handler.
- `ConcreteHandlerA/B` – Concrete implementations that handle specific requests.

---

## Usage

```csharp
var handlerA = new ConcreteHandlerA();
var handlerB = new ConcreteHandlerB();
handlerA.SetNext(handlerB);

Console.WriteLine(handlerA.Handle("A")); // Output: Handled by A
Console.WriteLine(handlerA.Handle("B")); // Output: Handled by B
Console.WriteLine(handlerA.Handle("C")); // Output: Not handled
```

---

## When to Use

- When multiple objects may handle a request and the handler isn’t known in advance.
- To avoid coupling the sender to a specific receiver.
