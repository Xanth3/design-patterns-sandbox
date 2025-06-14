# Observer Pattern

**Category:** Behavioural

The Observer pattern defines a one-to-many dependency between objects so that when one object changes state, all its dependents are notified and updated automatically.

---

## Structure

- `ISubject` – Interface for managing observers.
- `IObserver` – Interface for receiving updates.
- `ConcreteSubject` – Maintains state and notifies observers.
- `ConcreteObserver` – Reacts to updates from the subject.

---

## Usage

```csharp
var subject = new ConcreteSubject();
var observer1 = new ConcreteObserver();
subject.Attach(observer1);

subject.Notify("Hello observers!");
```

---

## When to Use

- When changes to one object require changing others.
- To implement distributed event handling systems.