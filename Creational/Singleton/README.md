# Singleton Pattern

**Category:** Creational

The Singleton pattern ensures a class has only one instance and provides a global point of access to it.

---

## Structure

- `Singleton` – The class that manages its sole instance and provides access to it.

---

## Usage

```csharp
var instance = Singleton.Instance;
Console.WriteLine(instance.GetMessage());
```

---

## When to Use

- When exactly one instance of a class is needed across the system.
- When controlled access to a shared resource is required.