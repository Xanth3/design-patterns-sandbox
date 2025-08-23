# Composite Pattern

**Category:** Structural

The Composite pattern lets you compose objects into tree structures to represent part-whole hierarchies. It lets clients treat individual objects and compositions uniformly.

---

## Structure

- `IComponent` – Interface for all components (leaf and composite).
- `Leaf` – Represents leaf objects in the composition.
- `Composite` – Represents composite objects that can have children.

---

## Usage

```csharp
IComponent root = new Composite("root");
IComponent branch = new Composite("branch");
IComponent leaf1 = new Leaf("leaf1");
IComponent leaf2 = new Leaf("leaf2");

branch.Add(leaf1);
root.Add(branch);
root.Add(leaf2);

Console.WriteLine(root.Operation());
// Output: Composite: root contains [Composite: branch contains [Leaf: leaf1], Leaf: leaf2]
```

---

## When to Use

- When you need to represent part-whole hierarchies.
- When you want clients to treat individual objects and compositions uniformly.
