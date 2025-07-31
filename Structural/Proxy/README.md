# Proxy Pattern

**Category:** Structural

The Proxy pattern provides a surrogate or placeholder for another object to control access, add functionality, or reduce cost of access.

---

## Structure

- `ISubject` – Interface for the subject.
- `RealSubject` – The real object that does the work.
- `Proxy` – Controls access to the RealSubject and may add extra behavior.

---

## Usage

```csharp
var realSubject = new RealSubject();
var proxy = new Proxy(realSubject);
proxy.AccessGranted = true;
Console.WriteLine(proxy.Request()); // Output: RealSubject: Handling request.

proxy.AccessGranted = false;
Console.WriteLine(proxy.Request()); // Output: Proxy: Access denied.
```

---

## When to Use

- To control access to an object.
- To add logging, caching, or lazy initialization.
- To represent a remote object locally.
