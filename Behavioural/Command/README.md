# Command Pattern

**Category:** Behavioural

The Command pattern encapsulates a request as an object, thereby letting you parameterise clients with different requests, queue or log requests, and support undoable operations.

---

## Structure

- `ICommand` – Interface for executing operations.
- `ConcreteCommand` – Implements the command and invokes the receiver.
- `Receiver` – Knows how to perform the operation.
- `Invoker` – Holds and invokes the command.

---

## Usage

```csharp
var receiver = new Receiver();
ICommand command = new ConcreteCommand(receiver);
var invoker = new Invoker();
invoker.SetCommand(command);
invoker.ExecuteCommand();
```

---

## When to Use

- To parameterise objects with operations.
- To support undo/redo, queuing, or logging of requests.
