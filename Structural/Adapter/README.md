# Adapter Pattern

**Category:** Structural

The Adapter pattern allows objects with incompatible interfaces to work together by wrapping an existing class with a new interface.

---

## Structure

- `ITarget` – The interface expected by the client.
- `Adaptee` – The existing class with an incompatible interface.
- `Adapter` – Wraps the `Adaptee` and adapts its interface to `ITarget`.

---

## Usage

```csharp
var adaptee = new Adaptee();
ITarget adapter = new Adapter(adaptee);
Console.WriteLine(adapter.GetRequest());
```

---

## When to Use

- Integrating legacy or third-party code with your application.
- Making unrelated classes work together without modifying their source.

